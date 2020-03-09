namespace ReadWriterFileKit
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOverviewFile = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnOverviewFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOverviewFile
            // 
            this.btnOverviewFile.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOverviewFile.Enabled = false;
            this.btnOverviewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverviewFile.Location = new System.Drawing.Point(92, 142);
            this.btnOverviewFile.Name = "btnOverviewFile";
            this.btnOverviewFile.Size = new System.Drawing.Size(155, 41);
            this.btnOverviewFile.TabIndex = 0;
            this.btnOverviewFile.Text = "Overview File";
            this.btnOverviewFile.UseVisualStyleBackColor = false;
            this.btnOverviewFile.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(22, 232);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 24);
            this.lblStatus.TabIndex = 1;
            // 
            // btnOverviewFolder
            // 
            this.btnOverviewFolder.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOverviewFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverviewFolder.Location = new System.Drawing.Point(77, 36);
            this.btnOverviewFolder.Name = "btnOverviewFolder";
            this.btnOverviewFolder.Size = new System.Drawing.Size(193, 41);
            this.btnOverviewFolder.TabIndex = 2;
            this.btnOverviewFolder.Text = "Overview Folder";
            this.btnOverviewFolder.UseVisualStyleBackColor = false;
            this.btnOverviewFolder.Click += new System.EventHandler(this.btnOverviewFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите путь к основной папке";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите нужный файл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статус:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOverviewFolder);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnOverviewFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(371, 304);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOverviewFile;
        public System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnOverviewFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

