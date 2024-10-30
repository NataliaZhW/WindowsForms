using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Diagnostics;

namespace Clock
{
    public partial class ChoozeFont : System.Windows.Forms.Form
    {
        public Font ChoozenFont { get; private set; } 
        public string FontFile { get; private set; } 
        
        public ChoozeFont()
        {
            InitializeComponent();
            LoadFonts(); 

        }
        public ChoozeFont(string fontFile) : this()
        {

            SetFontFile(FontFile);
        }
        public Font SetFontFile(string fontFile)
        {
            FontFile = fontFile;
            comboBoxFonts.SelectedIndex = comboBoxFonts.Items.IndexOf(FontFile);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFile);
            return new Font(pfc.Families[0],36);
        }
       
        void LoadFonts()
        {
            //1) Получаем список всех файлов в текущем каталоге, и сохраняем этот список в массив 'fonts':
            string[] fonts = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.ttf").ToArray();
            //fonts = fonts.Where(i => i.Split('\\').Last());

            //2) Поскольку в массиве хранятся полные пути к файлам, убираем пути, и оставляем только имена полученный файлов:
            for (int i = 0; i < fonts.Length; i++)
            {
                fonts[i] = fonts[i].Split('\\').Last();
            }
            comboBoxFonts.Items.Clear();

            //3) Загружаем весь массив файлов в ComboBox:
            comboBoxFonts.Items.AddRange(fonts);
            comboBoxFonts.SelectedIndex = 0;

        }

        private void comboBoxFonts_SelectedValueChanged(object sender, EventArgs e)
        {
            FontFile = $"{Directory.GetCurrentDirectory()}\\{comboBoxFonts.SelectedItem.ToString()}";
            //MessageBox.Show(fontFile);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(FontFile);

            Font font = new Font(pfc.Families[0], 36);
            //comboBoxFonts.Font = font;
            labelExample.Font = font;

            //PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile(comboBoxFonts.SelectedItem.ToString());//
            //Font font = new Font(pfc.Families[0], 24);
            //labelExample.Font = font;
        }
        
        private void btOK_Click(object sender, EventArgs e)
        {
            ChoozenFont = new Font(labelExample.Font.FontFamily, labelExample.Font.Size);
        }
    }
}
