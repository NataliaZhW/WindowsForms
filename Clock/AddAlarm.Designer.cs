namespace Clock
{
    partial class AddAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlarm));
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.labelFilename = new System.Windows.Forms.Label();
            this.btCooseFile = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btCooseCancel = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxExectDate = new System.Windows.Forms.CheckBox();
            this.checkedListBoxWeek = new System.Windows.Forms.CheckedListBox();
            this.openFileDialogSound = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(224, 39);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(142, 42);
            this.dateTimePickerTime.TabIndex = 0;
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilename.Location = new System.Drawing.Point(13, 125);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(75, 18);
            this.labelFilename.TabIndex = 2;
            this.labelFilename.Text = "FileName:";
            this.labelFilename.TextChanged += new System.EventHandler(this.labelFileName_TextChanged);
            // 
            // btCooseFile
            // 
            this.btCooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCooseFile.Location = new System.Drawing.Point(13, 153);
            this.btCooseFile.Name = "btCooseFile";
            this.btCooseFile.Size = new System.Drawing.Size(125, 23);
            this.btCooseFile.TabIndex = 3;
            this.btCooseFile.Text = "Выбрать файл ";
            this.btCooseFile.UseVisualStyleBackColor = true;
            this.btCooseFile.Click += new System.EventHandler(this.btCooseFile_Click);
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Enabled = false;
            this.btOK.Location = new System.Drawing.Point(210, 153);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCooseCancel
            // 
            this.btCooseCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCooseCancel.Location = new System.Drawing.Point(291, 153);
            this.btCooseCancel.Name = "btCooseCancel";
            this.btCooseCancel.Size = new System.Drawing.Size(75, 23);
            this.btCooseCancel.TabIndex = 5;
            this.btCooseCancel.Text = "Cancel";
            this.btCooseCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(12, 39);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(169, 42);
            this.dateTimePickerDate.TabIndex = 6;
            // 
            // checkBoxExectDate
            // 
            this.checkBoxExectDate.AutoSize = true;
            this.checkBoxExectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxExectDate.Location = new System.Drawing.Point(12, 13);
            this.checkBoxExectDate.Name = "checkBoxExectDate";
            this.checkBoxExectDate.Size = new System.Drawing.Size(158, 20);
            this.checkBoxExectDate.TabIndex = 7;
            this.checkBoxExectDate.Text = "на конкретную дату";
            this.checkBoxExectDate.UseVisualStyleBackColor = true;
            this.checkBoxExectDate.CheckedChanged += new System.EventHandler(this.checkBoxExectDate_CheckedChanged);
            // 
            // checkedListBoxWeek
            // 
            this.checkedListBoxWeek.CheckOnClick = true;
            this.checkedListBoxWeek.ColumnWidth = 50;
            this.checkedListBoxWeek.FormattingEnabled = true;
            this.checkedListBoxWeek.Items.AddRange(new object[] {
            "Пн",
            "Пт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
            this.checkedListBoxWeek.Location = new System.Drawing.Point(12, 88);
            this.checkedListBoxWeek.MultiColumn = true;
            this.checkedListBoxWeek.Name = "checkedListBoxWeek";
            this.checkedListBoxWeek.Size = new System.Drawing.Size(354, 19);
            this.checkedListBoxWeek.TabIndex = 8;
            // 
            // openFileDialogSound
            // 
            this.openFileDialogSound.FileName = "openFileDialogSound";
            // 
            // AddAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 184);
            this.Controls.Add(this.checkedListBoxWeek);
            this.Controls.Add(this.checkBoxExectDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.btCooseCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btCooseFile);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.dateTimePickerTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAlarm";
            this.Text = "AddAlarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Button btCooseFile;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCooseCancel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.CheckBox checkBoxExectDate;
        private System.Windows.Forms.CheckedListBox checkedListBoxWeek;
        private System.Windows.Forms.OpenFileDialog openFileDialogSound;
    }
}