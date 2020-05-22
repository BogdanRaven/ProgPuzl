namespace ProgPuzl
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картинкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гитлерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мопсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гомерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futuramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravityFallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.артЗГаріПотераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.witherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставитьНомеркиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labeltimermin = new System.Windows.Forms.Label();
            this.labeltimersec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.оПрограмеToolStripMenuItem,
            this.картинкаToolStripMenuItem,
            this.поставитьНомеркиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItem1.Text = "Новая игра";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // оПрограмеToolStripMenuItem
            // 
            this.оПрограмеToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.оПрограмеToolStripMenuItem.Name = "оПрограмеToolStripMenuItem";
            this.оПрограмеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.оПрограмеToolStripMenuItem.Text = "О програме";
            this.оПрограмеToolStripMenuItem.Click += new System.EventHandler(this.оПрограмеToolStripMenuItem_Click_1);
            // 
            // картинкаToolStripMenuItem
            // 
            this.картинкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гитлерToolStripMenuItem,
            this.мопсToolStripMenuItem,
            this.шрекToolStripMenuItem,
            this.гомерToolStripMenuItem,
            this.futuramaToolStripMenuItem,
            this.gravityFallsToolStripMenuItem,
            this.артЗГаріПотераToolStripMenuItem,
            this.witherToolStripMenuItem});
            this.картинкаToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.картинкаToolStripMenuItem.Name = "картинкаToolStripMenuItem";
            this.картинкаToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.картинкаToolStripMenuItem.Text = "Картинка";
            // 
            // гитлерToolStripMenuItem
            // 
            this.гитлерToolStripMenuItem.Name = "гитлерToolStripMenuItem";
            this.гитлерToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.гитлерToolStripMenuItem.Text = "Пикачу";
            this.гитлерToolStripMenuItem.Click += new System.EventHandler(this.ПикачуToolStripMenuItem_Click);
            // 
            // мопсToolStripMenuItem
            // 
            this.мопсToolStripMenuItem.Name = "мопсToolStripMenuItem";
            this.мопсToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.мопсToolStripMenuItem.Text = "PewDiPy";
            this.мопсToolStripMenuItem.Click += new System.EventHandler(this.мопсToolStripMenuItem_Click);
            // 
            // шрекToolStripMenuItem
            // 
            this.шрекToolStripMenuItem.Name = "шрекToolStripMenuItem";
            this.шрекToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.шрекToolStripMenuItem.Text = "Шрек";
            this.шрекToolStripMenuItem.Click += new System.EventHandler(this.шрекToolStripMenuItem_Click);
            // 
            // гомерToolStripMenuItem
            // 
            this.гомерToolStripMenuItem.Name = "гомерToolStripMenuItem";
            this.гомерToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.гомерToolStripMenuItem.Text = "Гомер";
            this.гомерToolStripMenuItem.Click += new System.EventHandler(this.гомерToolStripMenuItem_Click);
            // 
            // futuramaToolStripMenuItem
            // 
            this.futuramaToolStripMenuItem.Name = "futuramaToolStripMenuItem";
            this.futuramaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.futuramaToolStripMenuItem.Text = "Futurama";
            this.futuramaToolStripMenuItem.Click += new System.EventHandler(this.futuramaToolStripMenuItem_Click);
            // 
            // gravityFallsToolStripMenuItem
            // 
            this.gravityFallsToolStripMenuItem.Name = "gravityFallsToolStripMenuItem";
            this.gravityFallsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gravityFallsToolStripMenuItem.Text = "gravity falls";
            this.gravityFallsToolStripMenuItem.Click += new System.EventHandler(this.gravityFallsToolStripMenuItem_Click);
            // 
            // артЗГаріПотераToolStripMenuItem
            // 
            this.артЗГаріПотераToolStripMenuItem.Name = "артЗГаріПотераToolStripMenuItem";
            this.артЗГаріПотераToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.артЗГаріПотераToolStripMenuItem.Text = "Арт з Гарі Потера";
            this.артЗГаріПотераToolStripMenuItem.Click += new System.EventHandler(this.артЗГаріПотераToolStripMenuItem_Click);
            // 
            // witherToolStripMenuItem
            // 
            this.witherToolStripMenuItem.Name = "witherToolStripMenuItem";
            this.witherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.witherToolStripMenuItem.Text = "Wither";
            this.witherToolStripMenuItem.Click += new System.EventHandler(this.witherToolStripMenuItem_Click);
            // 
            // поставитьНомеркиToolStripMenuItem
            // 
            this.поставитьНомеркиToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.поставитьНомеркиToolStripMenuItem.Name = "поставитьНомеркиToolStripMenuItem";
            this.поставитьНомеркиToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.поставитьНомеркиToolStripMenuItem.Text = "Поставить номерки";
            this.поставитьНомеркиToolStripMenuItem.Click += new System.EventHandler(this.поставитьНомеркиToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labeltimermin
            // 
            this.labeltimermin.AutoSize = true;
            this.labeltimermin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltimermin.Location = new System.Drawing.Point(382, 3);
            this.labeltimermin.Name = "labeltimermin";
            this.labeltimermin.Size = new System.Drawing.Size(13, 15);
            this.labeltimermin.TabIndex = 1;
            this.labeltimermin.Text = "0";
            // 
            // labeltimersec
            // 
            this.labeltimersec.AutoSize = true;
            this.labeltimersec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltimersec.Location = new System.Drawing.Point(417, 3);
            this.labeltimersec.Name = "labeltimersec";
            this.labeltimersec.Size = new System.Drawing.Size(13, 15);
            this.labeltimersec.TabIndex = 2;
            this.labeltimersec.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(401, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeltimersec);
            this.Controls.Add(this.labeltimermin);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картинкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гитлерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мопсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставитьНомеркиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гомерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem futuramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravityFallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem артЗГаріПотераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem witherToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labeltimermin;
        private System.Windows.Forms.Label labeltimersec;
        private System.Windows.Forms.Label label1;
    }
}

