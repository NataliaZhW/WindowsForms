using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using Microsoft.Win32;


namespace Clock
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        ColorDialog backgroundColorDialog;
        ColorDialog foregroundColorDialog;
        ChoozeFont choozeFontDialog;
        FontDialog fontDialog;

        public MainForm()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Empty;
            backgroundColorDialog = new ColorDialog();
            foregroundColorDialog = new ColorDialog();

            //foregroundColorDialog.Color = Color.Blue;
            //backgroundColorDialog.Color = Color.Black;
           
            choozeFontDialog = new ChoozeFont();
            fontDialog = new FontDialog();
            
            SetVisibility(false);
            this.Location = new Point
            (10,//System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - this.Width
            10);//System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - this.Height
            this.Text += $"{this.Location.X}x{this.Location.Y}";
            SetFontDirectory();
        }

        void SetFontDirectory()
        {
            string location = Assembly.GetExecutingAssembly().Location;
            string path = Path.GetDirectoryName(location);
            //MessageBox.Show(path);
            Directory.SetCurrentDirectory($"{path}\\..\\..\\Fonts");
            //MessageBox.Show(Directory.GetCurrentDirectory());

        }

        //void SetStartup(bool autostart = false)
        //{
        //    RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        //    if (autostart) rk.SetValue("Clock", Application.ExecutablePath);
        //    else rk.DeleteValue("Clock", false);
        //    rk.Dispose();
        //}

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

            //SetVisibility(false);

            //поверхВсехОконToolStripMenuItem.Checked = false;
            toolStripMenuItemShowControls.Checked = false;
            //MessageBox.Show("Hide controls button");
        }

        private void labelTime_DoubleClick(object sender, EventArgs e)
        {
            //this.TransparencyKey = Color.Empty;
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            //this.ShowInTaskbar = true;
            //cbShowDate.Visible = true;
            //btnHideControls.Visible = true;
            //labelTime.BackColor = Color.Empty;
            
        //SetVisibility(true);
            
            //поверхВсехОконToolStripMenuItem.Checked = (поверхВсехОконToolStripMenuItem.Checked == false) ? true : false;
            toolStripMenuItemShowControls.Checked = true;
        }

        private void notifyIconSystemTray_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIconSystemTray.Text = "Curret time\n" + labelTime.Text;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void показатьДатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbShowDate.Checked = ((ToolStripMenuItem)sender).Checked;
        }

        private void поверхВсехОконToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = поверхВсехОконToolStripMenuItem.Checked;
        }

        private void toolStripMenuItemShowControls_Click(object sender, EventArgs e)
        {
            //поверхВсехОконToolStripMenuItem.Checked = (поверхВсехОконToolStripMenuItem.Checked == false)? true: false;
            //toolStripMenuItemTopmost.Checked = ((ToolStripMenuItem)sender).Checked;
            //toolStripMenuItemShowControls;
        }
        private void toolStripMenuItemShowControls_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibility(((ToolStripMenuItem)sender).Checked);//cbShowDate.Visible = true ? false : true;
        }

        private void notifyIconSystemTray_DoubleClick(object sender, EventArgs e)
        {
            if (!this.TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (foregroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.BackColor = foregroundColorDialog.Color;
            }
        }

        private void цветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.ForeColor = backgroundColorDialog.Color;
            }
        }

        private void выбратьШрифтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //if (fontDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    labelTime.Font = fontDialog.Font;
            //}
            if (choozeFontDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelTime.Font = choozeFontDialog.ChoozenFont;
            }
        }

        private void запускатьПриСтартеWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SetStartup(запускатьПриСтартеWindowsToolStripMenuItem.Checked);
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            //if (choozeFontDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    labelTime.Font = fontDialog.Font;
            //}
        }
    }
}
