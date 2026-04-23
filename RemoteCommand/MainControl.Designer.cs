namespace RemoteCommand
{
    partial class MainControl
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
            this.clinetsTable = new System.Windows.Forms.DataGridView();
            this.refershButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonStartServer = new System.Windows.Forms.RadioButton();
            this.radioButtonStopServer = new System.Windows.Forms.RadioButton();
            this.ColorAvtiveLable = new System.Windows.Forms.Label();
            this.PageTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clinetsTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clinetsTable
            // 
            this.clinetsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clinetsTable.Location = new System.Drawing.Point(14, 83);
            this.clinetsTable.Name = "clinetsTable";
            this.clinetsTable.Size = new System.Drawing.Size(637, 263);
            this.clinetsTable.TabIndex = 0;
            // 
            // refershButton
            // 
            this.refershButton.Location = new System.Drawing.Point(565, 352);
            this.refershButton.Name = "refershButton";
            this.refershButton.Size = new System.Drawing.Size(75, 23);
            this.refershButton.TabIndex = 1;
            this.refershButton.Text = "Refersh";
            this.refershButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonStopServer);
            this.groupBox1.Controls.Add(this.radioButtonStartServer);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 36);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonStartServer
            // 
            this.radioButtonStartServer.AutoSize = true;
            this.radioButtonStartServer.Location = new System.Drawing.Point(31, 13);
            this.radioButtonStartServer.Name = "radioButtonStartServer";
            this.radioButtonStartServer.Size = new System.Drawing.Size(107, 19);
            this.radioButtonStartServer.TabIndex = 0;
            this.radioButtonStartServer.Text = "Start Server";
            this.radioButtonStartServer.UseVisualStyleBackColor = true;
            // 
            // radioButtonStopServer
            // 
            this.radioButtonStopServer.AutoSize = true;
            this.radioButtonStopServer.Checked = true;
            this.radioButtonStopServer.Location = new System.Drawing.Point(236, 13);
            this.radioButtonStopServer.Name = "radioButtonStopServer";
            this.radioButtonStopServer.Size = new System.Drawing.Size(101, 19);
            this.radioButtonStopServer.TabIndex = 1;
            this.radioButtonStopServer.TabStop = true;
            this.radioButtonStopServer.Text = "Stop Server";
            this.radioButtonStopServer.UseVisualStyleBackColor = true;
            // 
            // ColorAvtiveLable
            // 
            this.ColorAvtiveLable.AutoSize = true;
            this.ColorAvtiveLable.Location = new System.Drawing.Point(552, 64);
            this.ColorAvtiveLable.Name = "ColorAvtiveLable";
            this.ColorAvtiveLable.Size = new System.Drawing.Size(88, 13);
            this.ColorAvtiveLable.TabIndex = 2;
            this.ColorAvtiveLable.Text = "ColorAvtiveLable";
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.Location = new System.Drawing.Point(260, 9);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(99, 29);
            this.PageTitle.TabIndex = 3;
            this.PageTitle.Text = "Clients";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PageTitle);
            this.Controls.Add(this.ColorAvtiveLable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refershButton);
            this.Controls.Add(this.clinetsTable);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(654, 387);
            ((System.ComponentModel.ISupportInitialize)(this.clinetsTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clinetsTable;
        private System.Windows.Forms.Button refershButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonStopServer;
        private System.Windows.Forms.RadioButton radioButtonStartServer;
        private System.Windows.Forms.Label ColorAvtiveLable;
        private System.Windows.Forms.Label PageTitle;
    }
}
