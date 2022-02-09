using Microsoft.Win32;

namespace AutomaticBackup
{
    public partial class Form1 : Form
    {
        protected bool IsAuto = false;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.btncancel.Click += Btncancel_Click;
            this.btnOK.Click += BtnOK_Click;
            this.btnAuto.Click += Button1_Click;
            this.btnNoAuto.Click += BtnNoAuto_Click;
            this.btnNoAutoBak.Click += BtnNoAutoBak_Click;
            this.nfi.DoubleClick += Nfi_DoubleClick;
            this.SizeChanged += Form1_SizeChanged;
            this.btnA.Click += BtnA_Click;
            this.btnexit.Click += Btnexit_Click;
        }

        private void Btnexit_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnA_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxold.Text) || string.IsNullOrWhiteSpace(tbxnew.Text))
            {
                MessageBox.Show("媳妇，先把路径填上");
            }
            else
                HelperNew.IsHaveOver(tbxold.Text, tbxnew.Text);
        }

        private void Form1_SizeChanged(object? sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.nfi.Visible = true;
            }
        }



        private void Nfi_DoubleClick(object? sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.nfi.Visible = false;
        }


        private void BtnNoAutoBak_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxold.Text) || string.IsNullOrWhiteSpace(tbxnew.Text))
            {
                MessageBox.Show("媳妇，先把路径填上");
            }
            else
                HelperNew.IsHaveOver(tbxold.Text, tbxnew.Text);
        }

        private void BtnNoAuto_Click(object? sender, EventArgs e)
        {
            using (MyContext context = new())
            {
                var ress = context.IsAuto.FirstOrDefault();
                if (ress != null)
                {
                    ress.Auto = 0;
                    IsAuto = false;
                    context.Update(ress);
                }
                else
                {
                    AutomaticBackup.IsAuto isAutos = new IsAuto();
                    isAutos.ID = Guid.NewGuid().ToString();
                    isAutos.Auto = 0;
                    IsAuto = false;
                    context.Add(isAutos);
                }
                context.SaveChanges();
            }
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            using (MyContext context = new())
            {
                var ress = context.IsAuto.FirstOrDefault();
                if (ress != null)
                {
                    ress.Auto = 1;
                    IsAuto = true;
                    context.Update(ress);
                }
                else
                {
                    AutomaticBackup.IsAuto isAutos = new IsAuto();
                    isAutos.ID = Guid.NewGuid().ToString();
                    isAutos.Auto = 1;
                    IsAuto = true;
                    context.Add(isAutos);
                }
                context.SaveChanges();
            }
            if (string.IsNullOrWhiteSpace(tbxold.Text) || string.IsNullOrWhiteSpace(tbxnew.Text))
            {
                MessageBox.Show("媳妇，先把路径填上");
            }
            else
            {
                Thread thread = new Thread(() => HaveAotu());
                thread.Start();
            }
        }

        private void BtnOK_Click(object? sender, EventArgs e)
        {
            try
            {
                using (MyContext context = new MyContext())
                {
                    var res = context.USB.FirstOrDefault();
                    if (res != null)
                    {
                        res.URL = tbxold.Text;
                        res.NewUrl = tbxnew.Text;
                        context.Update(res);
                    }
                    else
                    {
                        USB uSB = new USB();
                        uSB.ID = Guid.NewGuid().ToString();
                        uSB.URL = tbxold.Text;
                        uSB.NewUrl = tbxnew.Text;
                        context.Add(uSB);
                    }
                    context.SaveChanges();
                }
                MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存错误");
            }
        }

        private void Btncancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
//#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
//            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
//#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
//            registryKey.SetValue("AutomaticBackup", Application.ExecutablePath);
            using (MyContext db = new())
            {
                var res = db.USB.FirstOrDefault();
                if (res != null)
                {
                    this.tbxold.Text = res.URL;
                    this.tbxnew.Text = res.NewUrl;
                }
                var ress = db.IsAuto.FirstOrDefault();
                if (ress != null && ress.Auto == 1)
                    IsAuto = true;
            }
            if (string.IsNullOrWhiteSpace(tbxold.Text) || string.IsNullOrWhiteSpace(tbxnew.Text))
            {
                MessageBox.Show("媳妇，先把路径填上");
            }
            else
            {
                Thread thread = new Thread(() => HaveAotu());
                thread.Start();
            }
        }

        public void HaveAotu()
        {
            while (IsAuto)
            {
                HelperNew.IsHaveOver(tbxold.Text, tbxnew.Text);
                Thread.Sleep(1000 * 15);
            }
        }
    }
}