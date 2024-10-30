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
using System.Diagnostics;
using System.Threading;


namespace Clock
{

    public partial class MainForm : System.Windows.Forms.Form
    {
        ColorDialog backgroundColorDialog;
        ColorDialog foregroundColorDialog;
        ChoozeFont choozeFontDialog;
        AlarmList alarmList;
        FontDialog fontDialog;
        bool autoLoad;
        string fontName;
        string FontFile { get; set; }        

        public MainForm()
        {
            //Не работает
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeToolStripMenuItem_Click); //global_FormClosed


            //работает, выгружает
            int b = 0;
            DateTime time_p = new DateTime();
            foreach (Process process in Process.GetProcesses())
            {
                // выводим id и имя процесса
                //comboBoxFonts.Items.Add($"ID: {process.Id}  Name: {process.ProcessName}");

                if (process.ProcessName == "Clock")
                {
                    //MessageBox.Show($"ID: {process.Id}  Name: {process.ProcessName}  Time: {process.StartTime}  Time: {time_p}");
                    if (time_p < process.StartTime)
                    {
                        time_p = process.StartTime;//Convert.ToUInt32()
                    }
                    //MessageBox.Show($"Time: {time_p}");

                    //process. Modules. FileName();
                    //process.Kill();
                    //process.Start();
                    b++;
                }
                //Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
            }
            if (b > 1)
            {
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.ProcessName == "Clock")
                    {
                        //MessageBox.Show($"ID: {process.Id}  Name: {process.ProcessName}  Time: {process.StartTime}  Time: {time_p}");
                        if (time_p > process.StartTime)
                        {
                            process.Kill();
                        }
                        //MessageBox.Show($"Time: {time_p}");
                    }
                }
            }
            //if (!b)
            //{            
            InitializeComponent();
            //}
            AllocConsole();//????
            SetFontDirectory();
            this.TransparencyKey = Color.Empty;
            backgroundColorDialog = new ColorDialog();//цвет шрифта
            foregroundColorDialog = new ColorDialog();//цвет фона

            choozeFontDialog = new ChoozeFont();
            fontDialog = new FontDialog();
            LoadSettengs();
            alarmList = new AlarmList();

            //foregroundColorDialog.Color = Color.DarkSlateGray;
            //backgroundColorDialog.Color = Color.LawnGreen;// //Blue

            SetVisibility(false);

            this.Location = new Point
                (10,//System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - this.Width
                10);//System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - this.Height
            this.Text += $"{this.Location.X}x{this.Location.Y}";

        }
        void SetFontDirectory()
        {
            string location = Assembly.GetExecutingAssembly().Location;//Получаем полный адрес исполняемого файла
            string path = Path.GetDirectoryName(location);//Из адреса извлекаем путь к файлу
            //MessageBox.Show(path);
            Directory.SetCurrentDirectory($"{path}\\..\\..\\Fonts\\f2");//Переходим в каталог со шрифтами 
            //MessageBox.Show(Directory.GetCurrentDirectory());

        }


        void LoadSettengs()
        {
            StreamReader sr = new StreamReader("settings.txt");
            try
            {
                List<string> settengs = new List<string>();
                while (!sr.EndOfStream)
                {
                    settengs.Add(sr.ReadLine());
                }
                sr.Close();

                backgroundColorDialog.Color = Color.FromArgb(Convert.ToInt32(settengs.ToArray()[0]));
                foregroundColorDialog.Color = Color.FromArgb(Convert.ToInt32(settengs.ToArray()[1]));
                //sr.WriteLine(labelTime.);

                //Process.Start("notepad", "settings.txt");
                FontFile = settengs.ToArray()[2];
                topmostToolStripMenuItem.Checked = bool.Parse(settengs.ToArray()[3]);
                toolStripMenuItemShowDate.Checked = bool.Parse(settengs.ToArray()[4]); ;

                //MessageBox.Show(fontName);
                labelTime.Font = choozeFontDialog.SetFontFile(FontFile);
                labelTime.ForeColor = foregroundColorDialog.Color;
                labelTime.BackColor = backgroundColorDialog.Color;
                
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(
                             "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                object run = rk.GetValue("Clock");
                if (run != null) запускатьПриСтартеWindowsToolStripMenuItem.Checked = true;
                rk.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load settings error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sr.Close();
        }

        void SaveSettengs()
        {
            StreamWriter sw = new StreamWriter("settings.txt");
            sw.WriteLine(backgroundColorDialog.Color.ToArgb());
            sw.WriteLine(foregroundColorDialog.Color.ToArgb());

            sw.WriteLine(choozeFontDialog.FontFile.Split('\\').Last());// //labelTime.Font.Name
            sw.WriteLine(topmostToolStripMenuItem.Checked);
            sw.WriteLine(toolStripMenuItemShowDate.Checked);
            sw.WriteLine(запускатьПриСтартеWindowsToolStripMenuItem.Checked);

            sw.Close();
            //Process.Start("notepad", "settings.txt");
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
            labelTime.ForeColor = backgroundColorDialog.Color;//цвет шрифта? 
            labelTime.BackColor = foregroundColorDialog.Color;//цвет фона? Color.LightGoldenrodYellow
            //labelTime.ForeColor = visible ? Color.Empty : backgroundColorDialog.Color;//цвет шрифта? 
            //labelTime.BackColor = visible ? Color.Empty : foregroundColorDialog.Color;//цвет фона? Color.LightGoldenrodYellow
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            //SetVisibility(false);

            toolStripMenuItemShowControls.Checked = false;
            //MessageBox.Show("Hide controls button");
            //notifyIconSystemTray.ShowBalloonTip(3, "Alerts!", "Для того чтобы вернуть как было, нужно ткнуть 2 раза мышей по часам, или по этой иконке", ToolTipIcon.Info);
        }

        private void labelTime_DoubleClick(object sender, EventArgs e)
        {
            //SetVisibility(true);            
            //поверхВсехОконToolStripMenuItem.Checked = (поверхВсехОконToolStripMenuItem.Checked == false) ? true : false;
            toolStripMenuItemShowControls.Checked = true;
        }

        private void notifyIconSystemTray_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIconSystemTray.Text = "Curret time\n" + labelTime.Text;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void topmostToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topmostToolStripMenuItem.Checked;
        }

        private void showDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbShowDate.Checked = ((ToolStripMenuItem)sender).Checked;
        }


        private void toolStripMenuItemShowControls_Click(object sender, EventArgs e)
        {
            SetVisibility(((ToolStripMenuItem)sender).Checked);//???
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
            autoLoad = запускатьПриСтартеWindowsToolStripMenuItem.Checked;
            //путь в реестре до автозагрузки
            string keyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (autoLoad)
                {
                    key.SetValue("Clock", Application.ExecutablePath);
                }
                else
                {
                    key.DeleteValue("Clock", false);
                }
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            //if (choozeFontDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    labelTime.Font = fontDialog.Font;
            //}
        }

        private void labelTime_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettengs();
        }

        private void toolStripMenuItemShowDate_CheckedChanged(object sender, EventArgs e)
        {
            cbShowDate.Checked = ((ToolStripMenuItem)sender).Checked;
        }

        private void запускатьПриСтартеWindowsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ////SetStartup(запускатьПриСтартеWindowsToolStripMenuItem.Checked);
            //autoLoad = запускатьПриСтартеWindowsToolStripMenuItem.Checked;
            ////путь в реестре до автозагрузки
            //string keyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

            //using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
            //{
            //    if (autoLoad)
            //    {
            //        key.SetValue("Clock", Application.ExecutablePath);
            //    }
            //    else
            //    {
            //        key.DeleteValue("Clock", false);
            //    }
            //} //????key.Dispose();



            RegistryKey rk = Registry.CurrentUser.OpenSubKey(
                "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (запускатьПриСтартеWindowsToolStripMenuItem.Checked)
            {
                rk.SetValue("Clock", Application.ExecutablePath);
            }
            else
            {
                rk.DeleteValue("Clock", false);// не бросать исключение если запись отсутствует
            }
            rk.Dispose();
        }

        private void будильникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarmList.ShowDialog(this);
        }

        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
    }
}
