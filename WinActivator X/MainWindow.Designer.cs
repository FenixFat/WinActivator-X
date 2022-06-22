namespace WinActivator_X
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Tittle = new System.Windows.Forms.Label();
            this.Copy_lbl = new System.Windows.Forms.Label();
            this.gB_Desc = new System.Windows.Forms.GroupBox();
            this.Description = new System.Windows.Forms.Label();
            this.Edition = new MetroFramework.Controls.MetroComboBox();
            this.Win_Version = new MetroFramework.Controls.MetroComboBox();
            this.img_gB = new System.Windows.Forms.GroupBox();
            this.img_pB = new System.Windows.Forms.PictureBox();
            this.FbGroup_link = new System.Windows.Forms.PictureBox();
            this.Fb_link = new System.Windows.Forms.PictureBox();
            this.Web_link = new System.Windows.Forms.PictureBox();
            this.WinVersion_lbl = new System.Windows.Forms.Label();
            this.Edition_lbl = new System.Windows.Forms.Label();
            this.Activate_btn = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.gB_Desc.SuspendLayout();
            this.img_gB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_pB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FbGroup_link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fb_link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Web_link)).BeginInit();
            this.SuspendLayout();
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.Tittle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Tittle.Location = new System.Drawing.Point(16, 22);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(176, 37);
            this.Tittle.TabIndex = 1;
            this.Tittle.Text = "WinActivator X";
            // 
            // Copy_lbl
            // 
            this.Copy_lbl.AutoSize = true;
            this.Copy_lbl.Location = new System.Drawing.Point(65, 279);
            this.Copy_lbl.Name = "Copy_lbl";
            this.Copy_lbl.Size = new System.Drawing.Size(254, 13);
            this.Copy_lbl.TabIndex = 10;
            this.Copy_lbl.Text = "© 2021 - 2022 FenixFat Team - All Rights Reserved.";
            // 
            // gB_Desc
            // 
            this.gB_Desc.Controls.Add(this.Description);
            this.gB_Desc.Location = new System.Drawing.Point(178, 60);
            this.gB_Desc.Name = "gB_Desc";
            this.gB_Desc.Size = new System.Drawing.Size(270, 130);
            this.gB_Desc.TabIndex = 13;
            this.gB_Desc.TabStop = false;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Poppins", 8.5F);
            this.Description.Location = new System.Drawing.Point(8, 12);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(249, 110);
            this.Description.TabIndex = 9;
            this.Description.Text = "Programa, que le ayudará con la\r\nactivación de Windows (7/8/8.1/10/11) \r\ny las ed" +
    "iciones soportadas, usando KMS \r\nserver (s8.uk.to) y GVLK keys (Generic \r\nVolume" +
    " Licence Keys).\r\n";
            this.Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edition
            // 
            this.Edition.FormattingEnabled = true;
            this.Edition.ItemHeight = 23;
            this.Edition.Location = new System.Drawing.Point(150, 229);
            this.Edition.Name = "Edition";
            this.Edition.PromptText = "Seleccionar";
            this.Edition.Size = new System.Drawing.Size(170, 29);
            this.Edition.Style = MetroFramework.MetroColorStyle.Orange;
            this.Edition.TabIndex = 16;
            this.Edition.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Edition.UseSelectable = true;
            this.Edition.SelectedIndexChanged += new System.EventHandler(this.Edition_SelectedIndexChanged);
            // 
            // Win_Version
            // 
            this.Win_Version.FormattingEnabled = true;
            this.Win_Version.ItemHeight = 23;
            this.Win_Version.Items.AddRange(new object[] {
            "Win 7",
            "Win 8",
            "Win 8.1",
            "Win 10",
            "Win 11"});
            this.Win_Version.Location = new System.Drawing.Point(38, 229);
            this.Win_Version.Name = "Win_Version";
            this.Win_Version.PromptText = "Seleccionar";
            this.Win_Version.Size = new System.Drawing.Size(85, 29);
            this.Win_Version.Style = MetroFramework.MetroColorStyle.Orange;
            this.Win_Version.TabIndex = 14;
            this.Win_Version.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Win_Version.UseSelectable = true;
            this.Win_Version.SelectedIndexChanged += new System.EventHandler(this.Win_Version_SelectedIndexChanged);
            // 
            // img_gB
            // 
            this.img_gB.Controls.Add(this.img_pB);
            this.img_gB.Location = new System.Drawing.Point(23, 60);
            this.img_gB.Name = "img_gB";
            this.img_gB.Size = new System.Drawing.Size(135, 130);
            this.img_gB.TabIndex = 19;
            this.img_gB.TabStop = false;
            // 
            // img_pB
            // 
            this.img_pB.Image = ((System.Drawing.Image)(resources.GetObject("img_pB.Image")));
            this.img_pB.Location = new System.Drawing.Point(18, 18);
            this.img_pB.Name = "img_pB";
            this.img_pB.Size = new System.Drawing.Size(100, 100);
            this.img_pB.TabIndex = 18;
            this.img_pB.TabStop = false;
            // 
            // FbGroup_link
            // 
            this.FbGroup_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FbGroup_link.Image = global::WinActivator_X.Properties.Resources.FbGroup_icon;
            this.FbGroup_link.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FbGroup_link.Location = new System.Drawing.Point(380, 277);
            this.FbGroup_link.Name = "FbGroup_link";
            this.FbGroup_link.Size = new System.Drawing.Size(20, 20);
            this.FbGroup_link.TabIndex = 12;
            this.FbGroup_link.TabStop = false;
            // 
            // Fb_link
            // 
            this.Fb_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fb_link.Image = global::WinActivator_X.Properties.Resources.Fb_icon;
            this.Fb_link.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Fb_link.Location = new System.Drawing.Point(352, 277);
            this.Fb_link.Name = "Fb_link";
            this.Fb_link.Size = new System.Drawing.Size(20, 20);
            this.Fb_link.TabIndex = 11;
            this.Fb_link.TabStop = false;
            // 
            // Web_link
            // 
            this.Web_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Web_link.Image = global::WinActivator_X.Properties.Resources.Web_icon;
            this.Web_link.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Web_link.Location = new System.Drawing.Point(324, 277);
            this.Web_link.Name = "Web_link";
            this.Web_link.Size = new System.Drawing.Size(20, 20);
            this.Web_link.TabIndex = 9;
            this.Web_link.TabStop = false;
            this.Web_link.Tag = "";
            // 
            // WinVersion_lbl
            // 
            this.WinVersion_lbl.AutoSize = true;
            this.WinVersion_lbl.Font = new System.Drawing.Font("Poppins Light", 7.25F);
            this.WinVersion_lbl.Location = new System.Drawing.Point(37, 209);
            this.WinVersion_lbl.Name = "WinVersion_lbl";
            this.WinVersion_lbl.Size = new System.Drawing.Size(81, 17);
            this.WinVersion_lbl.TabIndex = 20;
            this.WinVersion_lbl.Text = "- Win Version -";
            this.WinVersion_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Edition_lbl
            // 
            this.Edition_lbl.AutoSize = true;
            this.Edition_lbl.Font = new System.Drawing.Font("Poppins Light", 7.25F);
            this.Edition_lbl.Location = new System.Drawing.Point(148, 209);
            this.Edition_lbl.Name = "Edition_lbl";
            this.Edition_lbl.Size = new System.Drawing.Size(103, 17);
            this.Edition_lbl.TabIndex = 21;
            this.Edition_lbl.Text = "- Windows Edition -";
            this.Edition_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Activate_btn
            // 
            this.Activate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Activate_btn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activate_btn.Location = new System.Drawing.Point(342, 205);
            this.Activate_btn.Name = "Activate_btn";
            this.Activate_btn.Size = new System.Drawing.Size(80, 26);
            this.Activate_btn.TabIndex = 22;
            this.Activate_btn.TabStop = false;
            this.Activate_btn.Text = "Activar";
            this.Activate_btn.UseVisualStyleBackColor = true;
            this.Activate_btn.Click += new System.EventHandler(this.Activate_btn_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset_btn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.Location = new System.Drawing.Point(342, 237);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(80, 26);
            this.Reset_btn.TabIndex = 23;
            this.Reset_btn.TabStop = false;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(480, 310);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Activate_btn);
            this.Controls.Add(this.Edition_lbl);
            this.Controls.Add(this.WinVersion_lbl);
            this.Controls.Add(this.img_gB);
            this.Controls.Add(this.Edition);
            this.Controls.Add(this.Win_Version);
            this.Controls.Add(this.gB_Desc);
            this.Controls.Add(this.FbGroup_link);
            this.Controls.Add(this.Fb_link);
            this.Controls.Add(this.Copy_lbl);
            this.Controls.Add(this.Web_link);
            this.Controls.Add(this.Tittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Opacity = 0.97D;
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.gB_Desc.ResumeLayout(false);
            this.gB_Desc.PerformLayout();
            this.img_gB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_pB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FbGroup_link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fb_link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Web_link)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.PictureBox FbGroup_link;
        private System.Windows.Forms.PictureBox Fb_link;
        private System.Windows.Forms.Label Copy_lbl;
        private System.Windows.Forms.PictureBox Web_link;
        private System.Windows.Forms.GroupBox gB_Desc;
        private System.Windows.Forms.Label Description;
        private MetroFramework.Controls.MetroComboBox Edition;
        private MetroFramework.Controls.MetroComboBox Win_Version;
        private System.Windows.Forms.PictureBox img_pB;
        private System.Windows.Forms.GroupBox img_gB;
        private System.Windows.Forms.Label WinVersion_lbl;
        private System.Windows.Forms.Label Edition_lbl;
        private System.Windows.Forms.Button Activate_btn;
        private System.Windows.Forms.Button Reset_btn;
    }
}

