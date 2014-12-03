namespace SimpleAzureCdn
{
    partial class simpleAzureCdnForm
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
            this.selectUploadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // selectUploadFile
            // 
            this.selectUploadFile.Location = new System.Drawing.Point(93, 46);
            this.selectUploadFile.Name = "selectUploadFile";
            this.selectUploadFile.Size = new System.Drawing.Size(156, 32);
            this.selectUploadFile.TabIndex = 0;
            this.selectUploadFile.Text = "Select and Upload file";
            this.selectUploadFile.UseVisualStyleBackColor = true;
            this.selectUploadFile.Click += new System.EventHandler(this.do_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // simpleAzureCdnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 172);
            this.Controls.Add(this.selectUploadFile);
            this.Name = "simpleAzureCdnForm";
            this.Text = "Simple File Select and Upload";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectUploadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

