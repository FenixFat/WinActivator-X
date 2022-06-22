using System;

namespace WinActivator_X.Common
{
    public partial class RestartPrompt : MetroFramework.Forms.MetroForm
    {
        public RestartPrompt()
        {
            InitializeComponent();
        }

        private void RestartPrompt_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void Restar_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-r -t 2");
            ActiveForm.Close();
        }

        private void RestarLater_btn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            Environment.Exit(0);
        }

    }
}
