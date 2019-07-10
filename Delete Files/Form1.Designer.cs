namespace Delete_Files
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbdelete = new System.Windows.Forms.TextBox();
            this.btstart = new System.Windows.Forms.Button();
            this.lsLog = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.запускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьЛогиКакФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressDelete = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Что удалить?";
            // 
            // tbdelete
            // 
            this.tbdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbdelete.Location = new System.Drawing.Point(233, 27);
            this.tbdelete.Name = "tbdelete";
            this.tbdelete.Size = new System.Drawing.Size(71, 38);
            this.tbdelete.TabIndex = 1;
            this.tbdelete.Text = "*.txt";
            // 
            // btstart
            // 
            this.btstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btstart.Location = new System.Drawing.Point(42, 71);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(218, 81);
            this.btstart.TabIndex = 2;
            this.btstart.Text = "Запуск!";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.Btstart_Click);
            // 
            // lsLog
            // 
            this.lsLog.FormattingEnabled = true;
            this.lsLog.ItemHeight = 16;
            this.lsLog.Location = new System.Drawing.Point(1, 214);
            this.lsLog.Name = "lsLog";
            this.lsLog.Size = new System.Drawing.Size(316, 212);
            this.lsLog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "логи";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запускToolStripMenuItem,
            this.показатьЛогиКакФайлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // запускToolStripMenuItem
            // 
            this.запускToolStripMenuItem.Name = "запускToolStripMenuItem";
            this.запускToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.запускToolStripMenuItem.Text = "Запуск!";
            this.запускToolStripMenuItem.Click += new System.EventHandler(this.ЗапускToolStripMenuItem_Click);
            // 
            // показатьЛогиКакФайлToolStripMenuItem
            // 
            this.показатьЛогиКакФайлToolStripMenuItem.Name = "показатьЛогиКакФайлToolStripMenuItem";
            this.показатьЛогиКакФайлToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.показатьЛогиКакФайлToolStripMenuItem.Text = "Показать логи ( как файл)";
            this.показатьЛогиКакФайлToolStripMenuItem.Click += new System.EventHandler(this.ПоказатьЛогиКакФайлToolStripMenuItem_Click);
            // 
            // progressDelete
            // 
            this.progressDelete.Location = new System.Drawing.Point(1, 426);
            this.progressDelete.Name = "progressDelete";
            this.progressDelete.Size = new System.Drawing.Size(316, 23);
            this.progressDelete.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.progressDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsLog);
            this.Controls.Add(this.btstart);
            this.Controls.Add(this.tbdelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Удалить файлы";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbdelete;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.ListBox lsLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem запускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьЛогиКакФайлToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressDelete;
    }
}

