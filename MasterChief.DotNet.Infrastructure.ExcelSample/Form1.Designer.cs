namespace MasterChief.DotNet.Infrastructure.ExcelSample
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnToExcel = new System.Windows.Forms.Button();
            this.btnToDataTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToExcel
            // 
            this.btnToExcel.Location = new System.Drawing.Point(28, 23);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(162, 23);
            this.btnToExcel.TabIndex = 0;
            this.btnToExcel.Text = "DataTable ToExcel";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.BtnToExcel_Click);
            // 
            // btnToDataTable
            // 
            this.btnToDataTable.Location = new System.Drawing.Point(221, 23);
            this.btnToDataTable.Name = "btnToDataTable";
            this.btnToDataTable.Size = new System.Drawing.Size(162, 23);
            this.btnToDataTable.TabIndex = 1;
            this.btnToDataTable.Text = "Excel ToDataTable";
            this.btnToDataTable.UseVisualStyleBackColor = true;
            this.btnToDataTable.Click += new System.EventHandler(this.BtnToDataTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 134);
            this.Controls.Add(this.btnToDataTable);
            this.Controls.Add(this.btnToExcel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.Button btnToDataTable;
    }
}

