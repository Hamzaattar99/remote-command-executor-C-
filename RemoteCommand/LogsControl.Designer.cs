namespace RemoteCommand
{
    partial class LogsControl
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
            this.LogsTable = new System.Windows.Forms.DataGridView();
            this.refershButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.Location = new System.Drawing.Point(301, 12);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(70, 29);
            this.PageTitle.TabIndex = 5;
            this.PageTitle.Text = "Logs";
            // 
            // LogsTable
            // 
            this.LogsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogsTable.Location = new System.Drawing.Point(26, 44);
            this.LogsTable.Name = "LogsTable";
            this.LogsTable.Size = new System.Drawing.Size(637, 263);
            this.LogsTable.TabIndex = 6;
            // 
            // refershButton
            // 
            this.refershButton.Location = new System.Drawing.Point(571, 313);
            this.refershButton.Name = "refershButton";
            this.refershButton.Size = new System.Drawing.Size(75, 23);
            this.refershButton.TabIndex = 7;
            this.refershButton.Text = "Refersh";
            this.refershButton.UseVisualStyleBackColor = true;
            // 
            // LogsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refershButton);
            this.Controls.Add(this.LogsTable);
            this.Controls.Add(this.PageTitle);
            this.Name = "LogsControl";
            this.Size = new System.Drawing.Size(674, 357);
            this.Load += new System.EventHandler(this.LogsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.DataGridView LogsTable;
        private System.Windows.Forms.Button refershButton;
    }
}
