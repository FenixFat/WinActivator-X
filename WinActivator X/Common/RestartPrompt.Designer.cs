namespace WinActivator_X.Common
{
    partial class RestartPrompt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestartPrompt));
            this.Restar_lbl = new System.Windows.Forms.Label();
            this.Restar_btn = new System.Windows.Forms.Button();
            this.RestarLater_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Restar_lbl
            // 
            this.Restar_lbl.AutoSize = true;
            this.Restar_lbl.Font = new System.Drawing.Font("Poppins", 9F);
            this.Restar_lbl.Location = new System.Drawing.Point(35, 22);
            this.Restar_lbl.Name = "Restar_lbl";
            this.Restar_lbl.Size = new System.Drawing.Size(386, 22);
            this.Restar_lbl.TabIndex = 0;
            this.Restar_lbl.Text = "Es necesario reiniciar su computadora para aplicar los cambios";
            // 
            // Restar_btn
            // 
            this.Restar_btn.Location = new System.Drawing.Point(97, 55);
            this.Restar_btn.Name = "Restar_btn";
            this.Restar_btn.Size = new System.Drawing.Size(88, 29);
            this.Restar_btn.TabIndex = 1;
            this.Restar_btn.TabStop = false;
            this.Restar_btn.Text = "Reiniciar";
            this.Restar_btn.UseVisualStyleBackColor = true;
            this.Restar_btn.Click += new System.EventHandler(this.Restar_btn_Click);
            // 
            // RestarLater_btn
            // 
            this.RestarLater_btn.Location = new System.Drawing.Point(207, 55);
            this.RestarLater_btn.Name = "RestarLater_btn";
            this.RestarLater_btn.Size = new System.Drawing.Size(155, 29);
            this.RestarLater_btn.TabIndex = 2;
            this.RestarLater_btn.TabStop = false;
            this.RestarLater_btn.Text = "Reiniciar más tarde";
            this.RestarLater_btn.UseVisualStyleBackColor = true;
            this.RestarLater_btn.Click += new System.EventHandler(this.RestarLater_btn_Click);
            // 
            // RestartPrompt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 100);
            this.Controls.Add(this.RestarLater_btn);
            this.Controls.Add(this.Restar_btn);
            this.Controls.Add(this.Restar_lbl);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "RestartPrompt";
            this.Opacity = 0.97D;
            this.Padding = new System.Windows.Forms.Padding(23, 88, 23, 29);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RestartPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Restar_lbl;
        private System.Windows.Forms.Button Restar_btn;
        private System.Windows.Forms.Button RestarLater_btn;
    }
}