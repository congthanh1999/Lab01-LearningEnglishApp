namespace Lab01
{
    partial class Dictionary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictionary));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_BackToMenu = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fruit",
            "Animal"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_BackToMenu
            // 
            this.btn_BackToMenu.ActiveImage = null;
            this.btn_BackToMenu.AllowAnimations = true;
            this.btn_BackToMenu.AllowBuffering = false;
            this.btn_BackToMenu.AllowToggling = false;
            this.btn_BackToMenu.AllowZooming = true;
            this.btn_BackToMenu.AllowZoomingOnFocus = false;
            this.btn_BackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_BackToMenu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_BackToMenu.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_BackToMenu.ErrorImage")));
            this.btn_BackToMenu.FadeWhenInactive = false;
            this.btn_BackToMenu.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_BackToMenu.Image = global::Lab01.Properties.Resources.Back;
            this.btn_BackToMenu.ImageActive = null;
            this.btn_BackToMenu.ImageLocation = null;
            this.btn_BackToMenu.ImageMargin = 40;
            this.btn_BackToMenu.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_BackToMenu.ImageZoomSize = new System.Drawing.Size(100, 100);
            this.btn_BackToMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_BackToMenu.InitialImage")));
            this.btn_BackToMenu.Location = new System.Drawing.Point(3, 3);
            this.btn_BackToMenu.Name = "btn_BackToMenu";
            this.btn_BackToMenu.Rotation = 0;
            this.btn_BackToMenu.ShowActiveImage = true;
            this.btn_BackToMenu.ShowCursorChanges = true;
            this.btn_BackToMenu.ShowImageBorders = true;
            this.btn_BackToMenu.ShowSizeMarkers = false;
            this.btn_BackToMenu.Size = new System.Drawing.Size(100, 100);
            this.btn_BackToMenu.TabIndex = 9;
            this.btn_BackToMenu.ToolTipText = "";
            this.btn_BackToMenu.WaitOnLoad = false;
            this.btn_BackToMenu.Zoom = 40;
            this.btn_BackToMenu.ZoomSpeed = 10;
            this.btn_BackToMenu.Click += new System.EventHandler(this.btn_BackToMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(3, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 430);
            this.panel1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(187, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(609, 424);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_BackToMenu);
            this.Name = "Dictionary";
            this.Size = new System.Drawing.Size(829, 572);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.UI.WinForms.BunifuImageButton btn_BackToMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
