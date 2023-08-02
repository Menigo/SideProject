namespace ControlWindows
{
    using System.Diagnostics;

    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "FindWindow")]
        extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        extern static bool ShowWindow(IntPtr hWnd, int nCmdShow);
        Process targetProcess = new Process();

        IntPtr nowhwnd = IntPtr.Zero;
        public Form1()
        {
            InitializeComponent();
        }

        IntPtr GetWindows()
        {
            Process[] processes = Process.GetProcesses();


            foreach (Process p in processes)
            {
                try
                {
                    ProcessModule? m = p.MainModule;
                }
                catch (Exception)
                {
                    continue;
                }
                if (!CheckPeocess(p.MainModule)) continue;
                string? s = p.MainModule?.ModuleName;
                if (s != null && s.Contains("csgo"))
                {
                    targetProcess = p;
                    break;
                }
            }
            //MessageBox.Show("請先啟動程式");
            IntPtr hwdl = new IntPtr(0);
            //hwdl = FindWindow(null, targetProcess.MainWindowTitle);
            hwdl = targetProcess.MainWindowHandle;
            return hwdl;
        }

        bool CheckPeocess(ProcessModule module)
        {
            if (module.ModuleName == null) return false;

            return true;
        }
        private void Hide_Btn_Click(object sender, EventArgs e)
        {
            IntPtr hwdl = GetWindows();
            if (hwdl != IntPtr.Zero)
            {
                MessageBox.Show("隱藏");
                ShowWindow(hwdl, 0);
                nowhwnd = hwdl;
                Hide_Btn.Enabled = false;
                Show_Btn.Enabled = true;
            }
            else MessageBox.Show("沒有找到窗口");
        }

        private void Show_Btn_Click(object sender, EventArgs e)
        {
            //IntPtr hwdl = GetWindows();
            if (nowhwnd != IntPtr.Zero)
            {
                MessageBox.Show("取消隱藏");
                ShowWindow(nowhwnd, 9);
                nowhwnd = IntPtr.Zero;
                Hide_Btn.Enabled = true;
                Show_Btn.Enabled = false;
            }
            else MessageBox.Show("沒有找到窗口");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nowhwnd != IntPtr.Zero)
            {
                MessageBox.Show("取消隱藏");
                ShowWindow(nowhwnd, 9);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            {
                // 顯示MessageBox 
                DialogResult Result = MessageBox.Show("確定關閉?", "下班?", MessageBoxButtons.YesNo);
                if (Result == System.Windows.Forms.DialogResult.Yes) this.Close();
                else return;
            }
            base.WndProc(ref m);
        }
    }
}