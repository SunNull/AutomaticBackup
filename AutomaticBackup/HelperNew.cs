namespace AutomaticBackup
{
    internal static class HelperNew
    {
        public static void IsHaveOver(string pathold, string pathnew)
        {
            //获取需要备份的路径
            DirectoryInfo dirold = new DirectoryInfo(pathold);
            //获取备份路径
            DirectoryInfo dirnew = new DirectoryInfo(pathnew);
            //判断两个路径是否存在，不存在则不进行备份
            if (dirold.Exists && dirnew.Exists)
            {
                //查询路径下所有文件
                IEnumerable<System.IO.FileInfo> listold = dirold.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
                IEnumerable<System.IO.FileInfo> listnew = dirnew.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
                //循环老路径，同时判断新路径是否存在或者判断文件大小是否一致
                foreach (var item in listold)
                {
                    var nofullname = item.FullName.Replace(pathold, "");
                    var noname = nofullname.Replace("\\" + item.Name, "");
                    //判断是否存在相同文件名的文件
                    var res = listnew.Where(t => t.Name == item.Name && t.FullName.Replace(pathnew, "") == nofullname).ToList();
                    if (res.Count > 0)
                    {
                        //判断待备份文件是否已经更新，如果更新则复制粘贴替换原来的文件
                        var rw = res.Where(t => t.Length != item.Length).ToList();
                        foreach (var im in rw)
                        {
                            try
                            {
                                item.CopyTo(im.FullName, true);
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(noname))
                            Directory.CreateDirectory(pathnew + noname);
                        item.CopyTo(pathnew + nofullname, true);
                    }
                }

            }
        }
    }
}
