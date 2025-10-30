namespace Rimrabic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtRoman = new System.Windows.Forms.TextBox();
            this.txtArabic = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnConvertToArabic = new System.Windows.Forms.Button();
            this.btnConvertToRoman = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.btnExportHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRoman
            // 
            this.txtRoman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoman.Location = new System.Drawing.Point(12, 51);
            this.txtRoman.Margin = new System.Windows.Forms.Padding(5);
            this.txtRoman.Name = "txtRoman";
            this.txtRoman.Size = new System.Drawing.Size(166, 32);
            this.txtRoman.TabIndex = 0;
            // 
            // txtArabic
            // 
            this.txtArabic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArabic.Location = new System.Drawing.Point(12, 108);
            this.txtArabic.Name = "txtArabic";
            this.txtArabic.Size = new System.Drawing.Size(166, 32);
            this.txtArabic.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(12, 164);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(166, 32);
            this.txtResult.TabIndex = 2;
            // 
            // btnConvertToArabic
            // 
            this.btnConvertToArabic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertToArabic.Location = new System.Drawing.Point(12, 209);
            this.btnConvertToArabic.Name = "btnConvertToArabic";
            this.btnConvertToArabic.Size = new System.Drawing.Size(192, 57);
            this.btnConvertToArabic.TabIndex = 3;
            this.btnConvertToArabic.Text = "Преобразовать в арабское число";
            this.btnConvertToArabic.UseVisualStyleBackColor = true;
            this.btnConvertToArabic.Click += new System.EventHandler(this.btnConvertToArabic_Click);
            // 
            // btnConvertToRoman
            // 
            this.btnConvertToRoman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertToRoman.Location = new System.Drawing.Point(12, 273);
            this.btnConvertToRoman.Name = "btnConvertToRoman";
            this.btnConvertToRoman.Size = new System.Drawing.Size(192, 55);
            this.btnConvertToRoman.TabIndex = 4;
            this.btnConvertToRoman.Text = "Преобразовать в римское число";
            this.btnConvertToRoman.UseVisualStyleBackColor = true;
            this.btnConvertToRoman.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(12, 391);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 37);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистить поля";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 26;
            this.lstHistory.Location = new System.Drawing.Point(276, 30);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(322, 402);
            this.lstHistory.TabIndex = 6;
            // 
            // btnExportHistory
            // 
            this.btnExportHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportHistory.Location = new System.Drawing.Point(436, 364);
            this.btnExportHistory.Name = "btnExportHistory";
            this.btnExportHistory.Size = new System.Drawing.Size(146, 57);
            this.btnExportHistory.TabIndex = 7;
            this.btnExportHistory.Text = "Выгрузить историю";
            this.btnExportHistory.UseVisualStyleBackColor = true;
            this.btnExportHistory.Click += new System.EventHandler(this.btnExportHistory_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Римские числа:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Арабские числа:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Результат:";
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFromFile.Location = new System.Drawing.Point(12, 335);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(192, 50);
            this.btnLoadFromFile.TabIndex = 11;
            this.btnLoadFromFile.Text = "Загрузить из файла";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 432);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportHistory);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvertToRoman);
            this.Controls.Add(this.btnConvertToArabic);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtArabic);
            this.Controls.Add(this.txtRoman);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(614, 471);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rimrabic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoman;
        private System.Windows.Forms.TextBox txtArabic;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnConvertToArabic;
        private System.Windows.Forms.Button btnConvertToRoman;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnExportHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

