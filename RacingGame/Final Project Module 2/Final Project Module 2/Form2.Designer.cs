
namespace Final_Project_Module_2
{
    partial class Form2
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
            this.PlayerRecord = new System.Windows.Forms.DataGridView();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerRecord
            // 
            this.PlayerRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerRecord.Location = new System.Drawing.Point(0, 0);
            this.PlayerRecord.Name = "PlayerRecord";
            this.PlayerRecord.Size = new System.Drawing.Size(1019, 581);
            this.PlayerRecord.TabIndex = 0;
            this.PlayerRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerRecord_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 581);
            this.Controls.Add(this.PlayerRecord);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayerRecord;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}