namespace Clock
{
    partial class AlarmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmList));
            this.listBoxAlarms = new System.Windows.Forms.ListBox();
            this.btAddAlarm = new System.Windows.Forms.Button();
            this.btDelAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAlarms
            // 
            this.listBoxAlarms.FormattingEnabled = true;
            this.listBoxAlarms.Location = new System.Drawing.Point(35, 28);
            this.listBoxAlarms.Name = "listBoxAlarms";
            this.listBoxAlarms.Size = new System.Drawing.Size(263, 95);
            this.listBoxAlarms.TabIndex = 0;
            this.listBoxAlarms.DoubleClick += new System.EventHandler(this.listBoxAlarms_DoubleClick);
            // 
            // btAddAlarm
            // 
            this.btAddAlarm.Location = new System.Drawing.Point(339, 28);
            this.btAddAlarm.Name = "btAddAlarm";
            this.btAddAlarm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAddAlarm.Size = new System.Drawing.Size(75, 23);
            this.btAddAlarm.TabIndex = 1;
            this.btAddAlarm.Text = "Добавить";
            this.btAddAlarm.UseVisualStyleBackColor = true;
            this.btAddAlarm.Click += new System.EventHandler(this.btAddAlarm_Click);
            // 
            // btDelAlarm
            // 
            this.btDelAlarm.Location = new System.Drawing.Point(339, 69);
            this.btDelAlarm.Name = "btDelAlarm";
            this.btDelAlarm.Size = new System.Drawing.Size(75, 23);
            this.btDelAlarm.TabIndex = 2;
            this.btDelAlarm.Text = "Удалить";
            this.btDelAlarm.UseVisualStyleBackColor = true;
            // 
            // AlarmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 302);
            this.Controls.Add(this.btDelAlarm);
            this.Controls.Add(this.btAddAlarm);
            this.Controls.Add(this.listBoxAlarms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlarmList";
            this.Text = "AlarmList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlarms;
        private System.Windows.Forms.Button btAddAlarm;
        private System.Windows.Forms.Button btDelAlarm;
    }
}