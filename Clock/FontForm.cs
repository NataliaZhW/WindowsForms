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
            comboBoxFonts.Items.AddRange(fonts);
        }

        private void comboBoxFonts_SelectedValueChanged(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();  
            pfc.AddFontFile(comboBoxFonts.SelectedItem.ToString());//
            Font font = new Font(pfc.Families[0], 22);
            labelExample.Font = font;
        }
        
        private void btOK_Click(object sender, EventArgs e)
        {
            ChoozenFont = new Font(labelExample.Font.FontFamily, labelExample.Font.Size);
        }
    }
}
