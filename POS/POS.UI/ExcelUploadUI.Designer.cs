namespace POS.UI
{
    partial class ExcelUploadUI
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.gvProductList = new System.Windows.Forms.DataGridView();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialogForUpload = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(38, 256);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(81, 29);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose File";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // gvProductList
            // 
            this.gvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductList.Location = new System.Drawing.Point(9, 10);
            this.gvProductList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvProductList.Name = "gvProductList";
            this.gvProductList.RowHeadersWidth = 51;
            this.gvProductList.RowTemplate.Height = 24;
            this.gvProductList.Size = new System.Drawing.Size(693, 228);
            this.gvProductList.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(136, 256);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(76, 29);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialogForUpload
            // 
            this.openFileDialogForUpload.FileName = "please chose excel file";
            this.openFileDialogForUpload.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogForUpload_FileOk);
            // 
            // ExcelUploadUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 295);
            this.Controls.Add(this.gvProductList);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnChoose);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExcelUploadUI";
            this.Text = "ExcelUploadUI";
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.DataGridView gvProductList;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialogForUpload;
    }
}