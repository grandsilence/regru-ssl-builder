namespace RegRuCertBuilder
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tbCert = new System.Windows.Forms.TextBox();
            this.msCertTextbox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCertClean = new System.Windows.Forms.ToolStripMenuItem();
            this.pnCert = new System.Windows.Forms.Panel();
            this.gbCert = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.msCertTextbox.SuspendLayout();
            this.pnCert.SuspendLayout();
            this.gbCert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCert
            // 
            this.tbCert.ContextMenuStrip = this.msCertTextbox;
            this.tbCert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCert.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCert.Location = new System.Drawing.Point(10, 26);
            this.tbCert.Margin = new System.Windows.Forms.Padding(4);
            this.tbCert.Multiline = true;
            this.tbCert.Name = "tbCert";
            this.tbCert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCert.Size = new System.Drawing.Size(486, 429);
            this.tbCert.TabIndex = 0;
            // 
            // msCertTextbox
            // 
            this.msCertTextbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCertClean});
            this.msCertTextbox.Name = "contextMenuStrip1";
            this.msCertTextbox.Size = new System.Drawing.Size(127, 26);
            // 
            // miCertClean
            // 
            this.miCertClean.Name = "miCertClean";
            this.miCertClean.Size = new System.Drawing.Size(126, 22);
            this.miCertClean.Text = "Очистить";
            this.miCertClean.Click += new System.EventHandler(this.miCertClean_Click);
            // 
            // pnCert
            // 
            this.pnCert.Controls.Add(this.gbCert);
            this.pnCert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCert.Location = new System.Drawing.Point(0, 0);
            this.pnCert.Margin = new System.Windows.Forms.Padding(4);
            this.pnCert.Name = "pnCert";
            this.pnCert.Padding = new System.Windows.Forms.Padding(10, 5, 10, 1);
            this.pnCert.Size = new System.Drawing.Size(526, 471);
            this.pnCert.TabIndex = 1;
            // 
            // gbCert
            // 
            this.gbCert.Controls.Add(this.tbCert);
            this.gbCert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCert.Location = new System.Drawing.Point(10, 5);
            this.gbCert.Margin = new System.Windows.Forms.Padding(4);
            this.gbCert.Name = "gbCert";
            this.gbCert.Padding = new System.Windows.Forms.Padding(10);
            this.gbCert.Size = new System.Drawing.Size(506, 465);
            this.gbCert.TabIndex = 1;
            this.gbCert.TabStop = false;
            this.gbCert.Text = "Сертификат из письма";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(0, 471);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(526, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 506);
            this.Controls.Add(this.pnCert);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(411, 332);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экспорт сертификата в файл (Reg.ru) - github.com/grandsilence";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.msCertTextbox.ResumeLayout(false);
            this.pnCert.ResumeLayout(false);
            this.gbCert.ResumeLayout(false);
            this.gbCert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbCert;
        private System.Windows.Forms.ContextMenuStrip msCertTextbox;
        private System.Windows.Forms.ToolStripMenuItem miCertClean;
        private System.Windows.Forms.Panel pnCert;
        private System.Windows.Forms.GroupBox gbCert;
        private System.Windows.Forms.Button btnSave;
    }
}

