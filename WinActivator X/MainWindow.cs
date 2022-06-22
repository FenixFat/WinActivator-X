using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace WinActivator_X
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        readonly string cmdPrefix = "slmgr.vbs //b ";

        public MainWindow()
        {
            InitializeComponent();

            if (Process.GetProcessesByName("WinActivator X").Length > 1)
            {
                MessageBox.Show("Hay una instancia de está aplicacion ejecutandose \n\nEl programa se cerrará . . .", "WinActivator X - FenixFat Team", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }

        }

        string licenseKey;

        private void Activate_btn_Click(object sender, EventArgs e)
        {
            Activate_btn.Enabled = false;

            if (Common.Globals.Edition == 0)
            {
                MessageBox.Show("Usted no ha seleccionado ninguna edición\n\nSeleccione una edición y vuelva a intentarlo.", "WinActivator X - By FenixFat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #region Windows 7 Keys
            if (Common.Globals.Edition == 1)
            {
                licenseKey = "FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4";
                WinActivate();
            }
            if (Common.Globals.Edition == 2)
            {
                licenseKey = "MRPKT-YTG23-K7D7T-X2JMM-QY7MG";
                WinActivate();
            }
            if (Common.Globals.Edition == 3)
            {
                licenseKey = "W82YF-2Q76Y-63HXB-FGJG9-GF7QX";
                WinActivate();
            }
            if (Common.Globals.Edition == 4)
            {
                licenseKey = "33PXH-7Y6KF-2VJC9-XBBR8-HVTHH";
                WinActivate();
            }
            if (Common.Globals.Edition == 5)
            {
                licenseKey = "YDRBP-3D83W-TY26F-D46B2-XCKRJ";
                WinActivate();
            }
            if (Common.Globals.Edition == 6)
            {
                licenseKey = "C29WB-22CC8-VJ326-GHFJW-H9DH4";
                WinActivate();
            }
            if (Common.Globals.Edition == 7)
            {
                licenseKey = "NG4HW-VH26C-733KW-K6F98-J8CK4";
                WinActivate();
            }
            #endregion
            #region Windows 8
            if (Common.Globals.Edition == 8)
            {
                licenseKey = "XCVCF-2NXM9-723PB-MHCB7-2RYQQ";
                WinActivate();
            }
            if (Common.Globals.Edition == 9)
            {
                licenseKey = "32JNW-9KQ84-P47T8-D8GGY-CWCK7";
                WinActivate();
            }
            if (Common.Globals.Edition == 10)
            {
                licenseKey = "JMNMF-RHW7P-DMY6X-RF3DR-X2BQT";
                WinActivate();
            }
            if (Common.Globals.Edition == 11)
            {
                licenseKey = "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9";
                WinActivate();
            }
            #endregion
            #region Windows 8.1
            if (Common.Globals.Edition == 12)
            {
                licenseKey = "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY";
                WinActivate();
            }
            if (Common.Globals.Edition == 13)
            {
                licenseKey = "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7";
                WinActivate();
            }
            if (Common.Globals.Edition == 14)
            {
                licenseKey = "TT4HM-HN7YT-62K67-RGRQJ-JFFXW";
                WinActivate();
            }
            if (Common.Globals.Edition == 15)
            {
                licenseKey = "M7XTQ-FN8P6-TTKYV-9D4CC-J462D";
                WinActivate();
            }
            #endregion
            #region Windows 10
            if (Common.Globals.Edition == 16)
            {
                licenseKey = "M7XTQ-FN8P6-TTKYV-9D4CC-J462D";
                WinActivate();
            }
            if (Common.Globals.Edition == 17)
            {
                licenseKey = "92NFX-8DJQP-P6BBQ-THF9C-7CG2H";
                WinActivate();
            }
            if (Common.Globals.Edition == 18)
            {
                licenseKey = "92NFX-8DJQP-P6BBQ-THF9C-7CG2H";
                WinActivate();
            }
            if (Common.Globals.Edition == 19)
            {
                licenseKey = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                WinActivate();
            }
            if (Common.Globals.Edition == 20)
            {
                licenseKey = "MH37W-N47XK-V7XM9-C7227-GCQG9";
                WinActivate();
            }
            if (Common.Globals.Edition == 21)
            {
                licenseKey = "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J";
                WinActivate();
            }
            if (Common.Globals.Edition == 22)
            {
                licenseKey = "9FNHH-K3HBT-3W4TD-6383H-6XYWF";
                WinActivate();
            }
            if (Common.Globals.Edition == 23)
            {
                licenseKey = "6TP4R-GNPTD-KYYHQ-7B7DP-J447Y";
                WinActivate();
            }
            if (Common.Globals.Edition == 24)
            {
                licenseKey = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC";
                WinActivate();
            }
            if (Common.Globals.Edition == 25)
            {
                licenseKey = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
                WinActivate();
            }
            if (Common.Globals.Edition == 26)
            {
                licenseKey = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
                WinActivate();
            }
            if (Common.Globals.Edition == 27)
            {
                licenseKey = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                WinActivate();
            }
            if (Common.Globals.Edition == 28)
            {
                licenseKey = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
                WinActivate();
            }
            if (Common.Globals.Edition == 29)
            {
                licenseKey = "YYVX9-NTFWV-6MDM3-9PT4T-4M68B";
                WinActivate();
            }
            if (Common.Globals.Edition == 30)
            {
                licenseKey = "44RPN-FTY23-9VTTB-MP9BX-T84FV";
                WinActivate();
            }
            if (Common.Globals.Edition == 31)
            {
                licenseKey = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                WinActivate();
            }
            #endregion
            #region Windows 11
            if (Common.Globals.Edition == 32)
            {
                licenseKey = "MH37W-N47XK-V7XM9-C7227-GCQG9";
                WinActivate();
            }
            if (Common.Globals.Edition == 33)
            {
                licenseKey = "MH37W-N47XK-V7XM9-C7227-GCQG9";
                WinActivate();
            }
            if (Common.Globals.Edition == 34)
            {
                licenseKey = "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J";
                WinActivate();
            }
            if (Common.Globals.Edition == 35)
            {
                licenseKey = "9FNHH-K3HBT-3W4TD-6383H-6XYWF";
                WinActivate();
            }
            if (Common.Globals.Edition == 36)
            {
                licenseKey = "6TP4R-GNPTD-KYYHQ-7B7DP-J447Y";
                WinActivate();
            }
            if (Common.Globals.Edition == 37)
            {
                licenseKey = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC";
                WinActivate();
            }
            if (Common.Globals.Edition == 38)
            {
                licenseKey = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
                WinActivate();
            }
            if (Common.Globals.Edition == 39)
            {
                licenseKey = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
                WinActivate();
            }
            if (Common.Globals.Edition == 40)
            {
                licenseKey = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                WinActivate();
            }
            if (Common.Globals.Edition == 41)
            {
                licenseKey = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
                WinActivate();
            }
            if (Common.Globals.Edition == 42)
            {
                licenseKey = "YYVX9-NTFWV-6MDM3-9PT4T-4M68B";
                WinActivate();
            }
            if (Common.Globals.Edition == 43)
            {
                licenseKey = "44RPN-FTY23-9VTTB-MP9BX-T84FV";
                WinActivate();
            }
            #endregion

            Activate_btn.Enabled = true;
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void WinActivate()
        {
            UninstallKey();
            InstallKey();
            SetKMSServer();
            RefreshKey();
            RestarWindow();
        }

        private void Reset()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                WorkingDirectory = @"C:\Windows\System32",
                Verb = "runas",
                FileName = @"C:\Windows\System32\cmd.exe",
                Arguments = "/c " + cmdPrefix + "-rearm "
            };
            process.StartInfo = startInfo;
            process.Start();
            Thread.Sleep(500);
            RestarWindow();
        }

        #region WinActivate Fuction
        private void UninstallKey()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                WorkingDirectory = @"C:\Windows\System32",
                Verb = "runas",
                FileName = @"C:\Windows\System32\cmd.exe",
                Arguments = "/c " + cmdPrefix + "/upk"
            };
            process.StartInfo = startInfo;
            process.Start();
            Thread.Sleep(500);
        }
        private void InstallKey()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                WorkingDirectory = @"C:\Windows\System32",
                Verb = "runas",
                FileName = @"C:\Windows\System32\cmd.exe",
                Arguments = "/c " + cmdPrefix + "-ipk " + licenseKey
            };
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            Thread.Sleep(500);
        }
        private void SetKMSServer()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                WorkingDirectory = @"C:\Windows\System32",
                Verb = "runas",
                FileName = @"C:\Windows\System32\cmd.exe",
                Arguments = "/c " + cmdPrefix + "-skms s8.uk.to"
            };
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            Thread.Sleep(500);
        }
        private void RefreshKey()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                WorkingDirectory = @"C:\Windows\System32",
                Verb = "runas",
                FileName = @"C:\Windows\System32\cmd.exe",
                Arguments = "/c " + cmdPrefix + "-ato"
            };
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            Thread.Sleep(500);
        }
        void RestarWindow()
        {
            ActiveForm.Visible = false;
            Common.RestartPrompt se = new Common.RestartPrompt();
            se.Show();
        }
        #endregion

        #region ComboBox's
        private void Win_Version_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Win_Version.SelectedIndex)
            {
                case 0:
                    Common.Globals.WinVersion = 1;
                    Edition.Items.Clear();
                    Edition.Items.Add("Professional");
                    Edition.Items.Add("Professional N");
                    Edition.Items.Add("Professional E");
                    Edition.Items.Add("Enterprise");
                    Edition.Items.Add("Enterprise N");
                    Edition.Items.Add("Enterprise E");
                    break;
                case 1:
                    Common.Globals.WinVersion = 2;
                    Edition.Items.Clear();
                    Edition.Items.Add("Pro");
                    Edition.Items.Add("Pro N");
                    Edition.Items.Add("Enterprise");
                    Edition.Items.Add("Enterprise N");
                    break;
                case 2:
                    Common.Globals.WinVersion = 3;
                    Edition.Items.Clear();
                    Edition.Items.Add("Pro");
                    Edition.Items.Add("Pro N");
                    Edition.Items.Add("Enterprise");
                    Edition.Items.Add("Enterprise N");
                    break;
                case 3:
                    Common.Globals.WinVersion = 4;
                    Edition.Items.Clear();
                    Edition.Items.Add("LTSC 2021");
                    Edition.Items.Add("LTSC 2019");
                    Edition.Items.Add("LTSC N 2021");
                    Edition.Items.Add("LTSC N 2019");
                    Edition.Items.Add("Pro");
                    Edition.Items.Add("Pro N");
                    Edition.Items.Add("Pro for Workstations");
                    Edition.Items.Add("Pro for Workstations N");
                    Edition.Items.Add("Pro Education");
                    Edition.Items.Add("Pro Education N");
                    Edition.Items.Add("Education");
                    Edition.Items.Add("Education N");
                    Edition.Items.Add("Enterprise");
                    Edition.Items.Add("Enterprise N");
                    Edition.Items.Add("Enterprise G");
                    Edition.Items.Add("Enterprise G N");
                    break;
                case 4:
                    Common.Globals.WinVersion = 5;
                    Edition.Items.Clear();
                    Edition.Items.Add("Pro");
                    Edition.Items.Add("Pro N");
                    Edition.Items.Add("Pro for Workstations");
                    Edition.Items.Add("Pro for Workstations N");
                    Edition.Items.Add("Pro Education");
                    Edition.Items.Add("Pro Education N");
                    Edition.Items.Add("Education");
                    Edition.Items.Add("Education N");
                    Edition.Items.Add("Enterprise");
                    Edition.Items.Add("Enterprise N");
                    Edition.Items.Add("Enterprise G");
                    Edition.Items.Add("Enterprise G N");
                    break;
            }

        }

        private void Edition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Common.Globals.WinVersion == 1)
            {
                switch (Edition.SelectedIndex)
                {
                    case 0:
                        Common.Globals.Edition = 1;
                        break;
                    case 1:
                        Common.Globals.Edition = 2;
                        break;
                    case 2:
                        Common.Globals.Edition = 3;
                        break;
                    case 3:
                        Common.Globals.Edition = 4;
                        break;
                    case 4:
                        Common.Globals.Edition = 5;
                        break;
                }
            }

            if (Common.Globals.WinVersion == 2)
            {
                switch (Edition.SelectedIndex)
                {
                    case 0:
                        Common.Globals.Edition = 6;
                        break;
                    case 1:
                        Common.Globals.Edition = 7;
                        break;
                    case 2:
                        Common.Globals.Edition = 8;
                        break;
                    case 3:
                        Common.Globals.Edition = 9;
                        break;
                }
            }

            if (Common.Globals.WinVersion == 3)
            {
                switch (Edition.SelectedIndex)
                {
                    case 0:
                        Common.Globals.Edition = 10;
                        break;
                    case 1:
                        Common.Globals.Edition = 11;
                        break;
                    case 2:
                        Common.Globals.Edition = 12;
                        break;
                    case 3:
                        Common.Globals.Edition = 13;
                        break;
                }
            }

            if (Common.Globals.WinVersion == 4)
            {
                switch (Edition.SelectedIndex)
                {
                    case 0:
                        Common.Globals.Edition = 14;
                        break;
                    case 1:
                        Common.Globals.Edition = 15;
                        break;
                    case 2:
                        Common.Globals.Edition = 16;
                        break;
                    case 3:
                        Common.Globals.Edition = 17;
                        break;
                    case 4:
                        Common.Globals.Edition = 18;
                        break;
                    case 5:
                        Common.Globals.Edition = 19;
                        break;
                    case 6:
                        Common.Globals.Edition = 20;
                        break;
                    case 7:
                        Common.Globals.Edition = 21;
                        break;
                    case 8:
                        Common.Globals.Edition = 22;
                        break;
                    case 9:
                        Common.Globals.Edition = 23;
                        break;
                    case 10:
                        Common.Globals.Edition = 24;
                        break;
                    case 11:
                        Common.Globals.Edition = 25;
                        break;
                    case 12:
                        Common.Globals.Edition = 26;
                        break;
                    case 13:
                        Common.Globals.Edition = 27;
                        break;
                    case 14:
                        Common.Globals.Edition = 28;
                        break;
                    case 15:
                        Common.Globals.Edition = 29;
                        break;
                    case 16:
                        Common.Globals.Edition = 30;
                        break;
                }
            }

            if (Common.Globals.WinVersion == 5)
            {
                switch (Edition.SelectedIndex)
                {
                    case 0:
                        Common.Globals.Edition = 31;
                        break;
                    case 1:
                        Common.Globals.Edition = 32;
                        break;
                    case 2:
                        Common.Globals.Edition = 33;
                        break;
                    case 3:
                        Common.Globals.Edition = 34;
                        break;
                    case 4:
                        Common.Globals.Edition = 35;
                        break;
                    case 5:
                        Common.Globals.Edition = 36;
                        break;
                    case 6:
                        Common.Globals.Edition = 37;
                        break;
                    case 7:
                        Common.Globals.Edition = 38;
                        break;
                    case 8:
                        Common.Globals.Edition = 39;
                        break;
                    case 9:
                        Common.Globals.Edition = 40;
                        break;
                    case 10:
                        Common.Globals.Edition = 41;
                        break;
                    case 11:
                        Common.Globals.Edition = 42;
                        break;
                    case 12:
                        Common.Globals.Edition = 43;
                        break;
                }
            }
        }
        #endregion

    }
}