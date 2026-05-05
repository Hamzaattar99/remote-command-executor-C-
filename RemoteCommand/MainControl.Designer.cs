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
            this.id_col = new System.Windows.Forms.DataGridViewButtonColumn();
            this.host_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.port_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mac_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conTime_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refershButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonStopServer = new System.Windows.Forms.RadioButton();
            this.radioButtonStartServer = new System.Windows.Forms.RadioButton();
            this.testLabel = new System.Windows.Forms.Label();
            this.PageTitle = new System.Windows.Forms.Label();
            this.activeServerColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.clinetsTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clinetsTable
            // 
            this.clinetsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clinetsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_col,
            this.host_col,
            this.ip_col,
            this.port_col,
            this.mac_col,
            this.conTime_col});
            this.clinetsTable.Location = new System.Drawing.Point(14, 83);
            this.clinetsTable.Name = "clinetsTable";
            this.clinetsTable.Size = new System.Drawing.Size(637, 263);
            this.clinetsTable.TabIndex = 0;
            // 
            // id_col
            // 
            this.id_col.HeaderText = "ID";
            this.id_col.Name = "id_col";
            this.id_col.ReadOnly = true;
            // 
            // host_col
            // 
            this.host_col.HeaderText = "Hostname";
            this.host_col.Name = "host_col";
            this.host_col.ReadOnly = true;
            // 
            // ip_col
            // 
            this.ip_col.HeaderText = "IP";
            this.ip_col.Name = "ip_col";
            this.ip_col.ReadOnly = true;
            // 
            // port_col
            // 
            this.port_col.HeaderText = "Port";
            this.port_col.Name = "port_col";
            this.port_col.ReadOnly = true;
            // 
            // mac_col
            // 
            this.mac_col.HeaderText = "Mac Address";
            this.mac_col.Name = "mac_col";
            this.mac_col.ReadOnly = true;
            // 
            // conTime_col
            // 
            this.conTime_col.HeaderText = "ConnectedTime";
            this.conTime_col.Name = "conTime_col";
            this.conTime_col.ReadOnly = true;
            // 
            // refershButton
            // 
            this.refershButton.Location = new System.Drawing.Point(565, 352);
            this.refershButton.Name = "refershButton";
            this.refershButton.Size = new System.Drawing.Size(75, 23);
            this.refershButton.TabIndex = 1;
            this.refershButton.Text = "Refersh";
            this.refershButton.UseVisualStyleBackColor = true;
            this.refershButton.Click += new System.EventHandler(this.refershButton_Click);
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
            this.radioButtonStopServer.CheckedChanged += new System.EventHandler(this.radioButtonStopServer_CheckedChanged);
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
            this.radioButtonStartServer.CheckedChanged += new System.EventHandler(this.radioButtonStartServer_CheckedChanged);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(117, 21);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(53, 13);
            this.testLabel.TabIndex = 2;
            this.testLabel.Text = "TestLabel";
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
            // activeServerColor
            // 
            this.activeServerColor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.activeServerColor.Location = new System.Drawing.Point(565, 41);
            this.activeServerColor.Name = "activeServerColor";
            this.activeServerColor.Size = new System.Drawing.Size(63, 25);
            this.activeServerColor.TabIndex = 4;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.activeServerColor);
            this.Controls.Add(this.PageTitle);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refershButton);
            this.Controls.Add(this.clinetsTable);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(665, 387);
            this.Load += new System.EventHandler(this.MainControl_Load);
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
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.Panel activeServerColor;
        private System.Windows.Forms.DataGridViewButtonColumn id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn host_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn port_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn mac_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn conTime_col;
    }
}
