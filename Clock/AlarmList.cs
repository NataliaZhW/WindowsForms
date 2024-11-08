using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class AlarmList : Form
    {
        public ListBox ListBoxAlarms 
        { 
            get=> listBoxAlarms; 
            private set => listBoxAlarms = value; 
        }
        public AlarmList()
        {
            InitializeComponent();
            LoadAlarmsFromFile("alarms.csv");
        }

        private void btAddAlarm_Click(object sender, EventArgs e)
        {
            AddAlarm addAlarm = new AddAlarm();
            //;
            if (addAlarm.ShowDialog(this) == DialogResult.OK)
            {
                listBoxAlarms.Items.Add(addAlarm.Alarm);//
            }
        }

        private void listBoxAlarms_DoubleClick(object sender, EventArgs e)
        {
            AddAlarm addAlarm = new AddAlarm((sender as ListBox).SelectedItem as Alarm);
            if (addAlarm.ShowDialog(this) == DialogResult.OK)
            {
                listBoxAlarms.SelectedItem = addAlarm.Alarm;
                listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = listBoxAlarms.Items[listBoxAlarms.SelectedIndex];
            };
            //if (ListBoxAlarms.SelectedItem != null)
            //{
            //    AddAlarms Addalarm = new AddAlarms(ListBoxAlarms.SelectedItem.ToString());
            //    Addalarm.ShowDialog(this);
            //}
        }
        public void SaveAlarmsToFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach (Alarm alarm in listBoxAlarms.Items)
            {
                sw.WriteLine(alarm.ToFileString());
            }
            sw.Close();
            Process.Start("notepad", filename);
        }
        public void LoadAlarmsFromFile(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename);
                while (!sr.EndOfStream)
                {
                    string alarm = sr.ReadLine();
                    listBoxAlarms.Items.Add(new Alarm(alarm));
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alarm warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btDelAlarm_Click(object sender, EventArgs e)
        {
            listBoxAlarms.Items.Remove(listBoxAlarms.SelectedItem);
        }
    }
}