namespace AutomaticBackup
{
    internal static class HelperNew
    {
        public static void IsHaveOver(string pathold, string pathnew)
        {
            DirectoryInfo dirold = new DirectoryInfo(pathold);
            DirectoryInfo dirnew = new DirectoryInfo(pathnew);
            if (dirold.Exists && dirnew.Exists)
            {
                IEnumerable<System.IO.FileInfo> listold = dirold.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
                IEnumerable<System.IO.FileInfo> listnew = dirnew.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
                foreach (var item in listold)
                {
                    var res = listnew.Where(t => t.Name == item.Name).ToList();
                    if (res.Count > 0)
                    {
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
                        item.CopyTo(pathnew+"\\"+item.Name, true);
                    }
                }

            }
        }
    }
}
