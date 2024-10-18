namespace Clock
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.выбратьШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.поверхВсехОконToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьЭлементыКправленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.показатьДатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выборЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьШрифтToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.запускатьПриСтартеWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.Info;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(12, 69);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(74, 31);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Time";
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowDate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbShowDate.Location = new System.Drawing.Point(12, 124);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(176, 29);
            this.cbShowDate.TabIndex = 1;
            this.cbShowDate.Text = "Показать дату";
            this.cbShowDate.UseVisualStyleBackColor = true;
            // 
            // btnHideControls
            // 
            this.btnHideControls.BackColor = System.Drawing.SystemColors.Info;
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHideControls.Location = new System.Drawing.Point(12, 159);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(176, 40);
            this.btnHideControls.TabIndex = 2;
            this.btnHideControls.Text = "Скрыть элементы управления";
            this.btnHideControls.UseVisualStyleBackColor = false;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.BalloonTipTitle = "Current time";
            this.notifyIconSystemTray.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "notifyIconSystemTray";
            this.notifyIconSystemTray.Visible = true;
            this.notifyIconSystemTray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseMove);
            // 
            // выбратьШрифтToolStripMenuItem
            // 
            this.выбратьШрифтToolStripMenuItem.Name = "выбратьШрифтToolStripMenuItem";
            this.выбратьШрифтToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.выбратьШрифтToolStripMenuItem.Text = "Выбрать шрифт";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.toolStripButton2,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(224, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поверхВсехОконToolStripMenuItem,
            this.показатьЭлементыКправленияToolStripMenuItem,
            this.toolStripSeparator1,
            this.показатьДатуToolStripMenuItem,
            this.toolStripSeparator2,
            this.выборЦветаToolStripMenuItem,
            this.выбратьШрифтToolStripMenuItem1,
            this.toolStripSeparator3,
            this.запускатьПриСтартеWindowsToolStripMenuItem,
            this.toolStripSeparator4,
            this.закрытьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(251, 182);
            // 
            // поверхВсехОконToolStripMenuItem
            // 
            this.поверхВсехОконToolStripMenuItem.CheckOnClick = true;
            this.поверхВсехОконToolStripMenuItem.Name = "поверхВсехОконToolStripMenuItem";
            this.поверхВсехОконToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.поверхВсехОконToolStripMenuItem.Text = "Поверх всех окон";
            // 
            // показатьЭлементыКправленияToolStripMenuItem
            // 
            this.показатьЭлементыКправленияToolStripMenuItem.Name = "показатьЭлементыКправленияToolStripMenuItem";
            this.показатьЭлементыКправленияToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.показатьЭлементыКправленияToolStripMenuItem.Text = "Показать элементы управления";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // показатьДатуToolStripMenuItem
            // 
            this.показатьДатуToolStripMenuItem.Name = "показатьДатуToolStripMenuItem";
            this.показатьДатуToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.показатьДатуToolStripMenuItem.Text = "Показать дату";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
            // 
            // выборЦветаToolStripMenuItem
            // 
            this.выборЦветаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветФонаToolStripMenuItem,
            this.цветШрифтаToolStripMenuItem});
            this.выборЦветаToolStripMenuItem.Name = "выборЦветаToolStripMenuItem";
            this.выборЦветаToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.выборЦветаToolStripMenuItem.Text = "Выбор цвета";
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            // 
            // цветШрифтаToolStripMenuItem
            // 
            this.цветШрифтаToolStripMenuItem.Name = "цветШрифтаToolStripMenuItem";
            this.цветШрифтаToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.цветШрифтаToolStripMenuItem.Text = "Цвет шрифта";
            // 
            // выбратьШрифтToolStripMenuItem1
            // 
            this.выбратьШрифтToolStripMenuItem1.Name = "выбратьШрифтToolStripMenuItem1";
            this.выбратьШрифтToolStripMenuItem1.Size = new System.Drawing.Size(250, 22);
            this.выбратьШрифтToolStripMenuItem1.Text = "Выбрать шрифт";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(247, 6);
            // 
            // запускатьПриСтартеWindowsToolStripMenuItem
            // 
            this.запускатьПриСтартеWindowsToolStripMenuItem.Name = "запускатьПриСтартеWindowsToolStripMenuItem";
            this.запускатьПриСтартеWindowsToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.запускатьПриСтартеWindowsToolStripMenuItem.Text = "Запускать при старте Windows";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(247, 6);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(224, 211);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 250);
            this.MinimumSize = new System.Drawing.Size(240, 250);
            this.Name = "MainForm";
            this.Text = "Clock";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.NotifyIcon notifyIconSystemTray;
        private System.Windows.Forms.ToolStripMenuItem выбратьШрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поверхВсехОконToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьЭлементыКправленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem показатьДатуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выборЦветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьШрифтToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem запускатьПриСтартеWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

