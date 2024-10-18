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
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
            //this.TransparencyKey = Color.Empty;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (cbShowDate.Checked)
            {
                labelTime.Text += $"\n{DateTime.Today.ToString("yyyy.MM.dd")}";                
            }
            //notifyIconSystemTray.Text = "Curret time " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void SetVisibility(bool visible)
        {
            this.TransparencyKey = visible ? Color.Empty : this.BackColor;//цвет
            this.FormBorderStyle = visible ? FormBorderStyle.Sizable : FormBorderStyle.None;//скрыть элементы управления
            this.ShowInTaskbar = visible;//часы
            cbShowDate.Visible = visible;//дата
            btnHideControls.Visible = visible;//скрыть
            // Visible - видимость 
            labelTime.BackColor = visible ? Color.Empty : Color.LightGoldenrodYellow;//фон
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            //this.TransparencyKey = this.BackColor;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.ShowInTaskbar = false;
            //cbShowDate.Visible = false;
            //btnHideControls.Visible = false;
            //labelTime.BackColor = Color.LightGoldenrodYellow;
            SetVisibility(false);
        }

        private void labelTime_DoubleClick(object sender, EventArgs e)
        {
            //this.TransparencyKey = Color.Empty;
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            //this.ShowInTaskbar = true;
            //cbShowDate.Visible = true;
            //btnHideControls.Visible = true;
            //labelTime.BackColor = Color.Empty;
            SetVisibility(true);
        }

        private void notifyIconSystemTray_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIconSystemTray.Text = "Curret time\n" + labelTime.Text;
        }
    }
}
