using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class AddAlarm : Form
    {
        //Alarm Alarm;
        public Alarm Alarm { get; set; }
        public AddAlarm()
        {
            InitializeComponent();
            Alarm = new Alarm();
            //labelFilename.SetBounds(labelFilename.Location.X, labelFilename.Location.Y, this.Width - 10, 75);
            //labelFilename.MaximumSize = new Size(this,Midth - 10, 75);
            labelFilename.MaximumSize = new Size(this.Width - 25, 75);
            //alarm = new Alarm();
            openFileDialogSound.Filter = "MP-3 (*.mp3)|*.mp3|Flac (*.flac)|*.flac|All Audio|*.mp3;*.flac";

        }
        void InitAlarm()
        {
            Alarm.Date = dateTimePickerDate.Enabled ? dateTimePickerDate.Value : DateTime.MinValue;            
            Alarm.Time = dateTimePickerTime.Value;
            Alarm.Filename = labelFilename.Text;
            for (int i = 0; i < checkedListBoxWeek.CheckedIndices.Count; i++)//checkedListBoxWeek.Items[i]
            {
                //Свойство 'CheckedIndices' - это коллекция, которая содержит индексы выбраннх Галочек в checkedListBox.
                //Alarm.Weekdays[i] = (checkedListBoxWeek.Items[i] as CheckBox).Checked;
                Alarm.Weekdays[checkedListBoxWeek.CheckedIndices[i]] = true;
                Console.Write(checkedListBoxWeek.CheckedIndices[i] + "\t");
            }
            Console.WriteLine();            
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            InitAlarm();
            //checkedListBoxWeek.Enabled=true; 
            //if (Alarm.Filename == "FileName:")
            //{
            //    MessageBox.Show("Выберите файл","Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}                        
            //this.Close();
        }

        private void checkBoxExectDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDate.Enabled = ((CheckBox)sender).Checked; ;
        }

        private void labelFileName_TextChanged(object sender, EventArgs e)
        {
            btOK.Enabled = true;
        }

        
        private void btCooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogSound.ShowDialog(this) == DialogResult.OK)
            {
                Alarm.Filename = labelFilename.Text = openFileDialogSound.FileName;
            }

        }
    }
}
