namespace RemoteCommand
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContenPanel = new System.Windows.Forms.Panel();
            this.MainButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SessionsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.LogsButton);
            this.panel1.Controls.Add(this.SessionsButton);
            this.panel1.Controls.Add(this.MainButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 386);
            this.panel1.TabIndex = 0;
            // 
            // ContenPanel
            // 
            this.ContenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenPanel.Location = new System.Drawing.Point(62, 0);
            this.ContenPanel.Name = "ContenPanel";
            this.ContenPanel.Size = new System.Drawing.Size(807, 386);
            this.ContenPanel.TabIndex = 1;
            // 
            // MainButton
            // 
            this.MainButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.MainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.MainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainButton.BorderRadius = 0;
            this.MainButton.ButtonText = "";
            this.MainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainButton.DisabledColor = System.Drawing.Color.Gray;
            this.MainButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MainButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("MainButton.Iconimage")));
            this.MainButton.Iconimage_right = null;
            this.MainButton.Iconimage_right_Selected = null;
            this.MainButton.Iconimage_Selected = null;
            this.MainButton.IconMarginLeft = 0;
            this.MainButton.IconMarginRight = 0;
            this.MainButton.IconRightVisible = true;
            this.MainButton.IconRightZoom = 0D;
            this.MainButton.IconVisible = true;
            this.MainButton.IconZoom = 90D;
            this.MainButton.IsTab = false;
            this.MainButton.Location = new System.Drawing.Point(12, 12);
            this.MainButton.Name = "MainButton";
            this.MainButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.MainButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.MainButton.OnHoverTextColor = System.Drawing.Color.White;
            this.MainButton.selected = false;
            this.MainButton.Size = new System.Drawing.Size(43, 48);
            this.MainButton.TabIndex = 0;
            this.MainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButton.Textcolor = System.Drawing.Color.White;
            this.MainButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // SessionsButton
            // 
            this.SessionsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SessionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SessionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SessionsButton.BorderRadius = 0;
            this.SessionsButton.ButtonText = "";
            this.SessionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SessionsButton.DisabledColor = System.Drawing.Color.Gray;
            this.SessionsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SessionsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("SessionsButton.Iconimage")));
            this.SessionsButton.Iconimage_right = null;
            this.SessionsButton.Iconimage_right_Selected = null;
            this.SessionsButton.Iconimage_Selected = null;
            this.SessionsButton.IconMarginLeft = 0;
            this.SessionsButton.IconMarginRight = 0;
            this.SessionsButton.IconRightVisible = true;
            this.SessionsButton.IconRightZoom = 0D;
            this.SessionsButton.IconVisible = true;
            this.SessionsButton.IconZoom = 90D;
            this.SessionsButton.IsTab = false;
            this.SessionsButton.Location = new System.Drawing.Point(12, 86);
            this.SessionsButton.Name = "SessionsButton";
            this.SessionsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SessionsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.SessionsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SessionsButton.selected = false;
            this.SessionsButton.Size = new System.Drawing.Size(43, 48);
            this.SessionsButton.TabIndex = 0;
            this.SessionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SessionsButton.Textcolor = System.Drawing.Color.White;
            this.SessionsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionsButton.Click += new System.EventHandler(this.SessionsButton_Click);
            // 
            // LogsButton
            // 
            this.LogsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.LogsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.LogsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogsButton.BorderRadius = 0;
            this.LogsButton.ButtonText = "";
            this.LogsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogsButton.DisabledColor = System.Drawing.Color.Gray;
            this.LogsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LogsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("LogsButton.Iconimage")));
            this.LogsButton.Iconimage_right = null;
            this.LogsButton.Iconimage_right_Selected = null;
            this.LogsButton.Iconimage_Selected = null;
            this.LogsButton.IconMarginLeft = 0;
            this.LogsButton.IconMarginRight = 0;
            this.LogsButton.IconRightVisible = true;
            this.LogsButton.IconRightZoom = 0D;
            this.LogsButton.IconVisible = true;
            this.LogsButton.IconZoom = 90D;
            this.LogsButton.IsTab = false;
            this.LogsButton.Location = new System.Drawing.Point(12, 161);
            this.LogsButton.Name = "LogsButton";
            this.LogsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.LogsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.LogsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.LogsButton.selected = false;
            this.LogsButton.Size = new System.Drawing.Size(43, 48);
            this.LogsButton.TabIndex = 0;
            this.LogsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogsButton.Textcolor = System.Drawing.Color.White;
            this.LogsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsButton.Click += new System.EventHandler(this.LogsButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 386);
            this.Controls.Add(this.ContenPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ContenPanel;
        private Bunifu.Framework.UI.BunifuFlatButton LogsButton;
        private Bunifu.Framework.UI.BunifuFlatButton SessionsButton;
        private Bunifu.Framework.UI.BunifuFlatButton MainButton;

    }
}

