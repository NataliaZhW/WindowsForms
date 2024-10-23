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
        
        public ChoozeFont()
        {
            InitializeComponent();
        }

        private void ChoozeFont_Load(object sender, EventArgs e)
        {           
            string[] fonts = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.ttf").ToArray();
            //fonts = fonts.Where(i => i.Split('\\').Last());
            
            for (int i = 0; i < fonts.Length; i++)
            {
                fonts[i] = fonts[i].Split('\\').Last();
            }
            comboBoxFonts.Items.Clear();

            comboBoxFonts.Items.AddRange(fonts);
            comboBoxFonts.SelectedIndex = 0;

        }

        private void comboBoxFonts_SelectedValueChanged(object sender, EventArgs e)
        {
            string fontFile = $"{Directory.GetCurrentDirectory()}\\{comboBoxFonts.SelectedItem.ToString()}";
            MessageBox.Show(fontFile);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(fontFile);

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
