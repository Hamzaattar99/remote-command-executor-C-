namespace RemoteCommand
{
    partial class SessionsControl
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
            this.PageTitle = new System.Windows.Forms.Label();
            this.sessionsTable = new System.Windows.Forms.DataGridView();
            this.refershButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.Location = new System.Drawing.Point(282, 15);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(119, 29);
            this.PageTitle.TabIndex = 4;
            this.PageTitle.Text = "Sessions";
            // 
            // sessionsTable
            // 
            this.sessionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionsTable.Location = new System.Drawing.Point(24, 47);
            this.sessionsTable.Name = "sessionsTable";
            this.sessionsTable.Size = new System.Drawing.Size(637, 263);
            this.sessionsTable.TabIndex = 5;
            // 
            // refershButton
            // 
            this.refershButton.Location = new System.Drawing.Point(577, 316);
            this.refershButton.Name = "refershButton";
            this.refershButton.Size = new System.Drawing.Size(75, 23);
            this.refershButton.TabIndex = 6;
            this.refershButton.Text = "Refersh";
            this.refershButton.UseVisualStyleBackColor = true;
            // 
            // SessionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refershButton);
            this.Controls.Add(this.sessionsTable);
            this.Controls.Add(this.PageTitle);
            this.Name = "SessionsControl";
            this.Size = new System.Drawing.Size(685, 355);
            ((System.ComponentModel.ISupportInitialize)(this.sessionsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.DataGridView sessionsTable;
        private System.Windows.Forms.Button refershButton;
    }
}
