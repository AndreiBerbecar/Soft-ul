using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soft_educational
{
    public partial class Bibiografie : Form
    {
        public Bibiografie()
        {
            InitializeComponent();
        }

        private void lblLinks_Click(object sender, EventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://ro.wikipedia.org/wiki/Europa");
        }

        private void lblLinks2_Click(object sender, EventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://ro.m.wikipedia.org/wiki/Lista_capitalelor_europene_dup%C4%83_suprafa%C8%9B%C4%83");
        }

        private void lblLinks3_Click(object sender, EventArgs e)
        {
            _=System.Diagnostics.Process.Start("https://www.plimbaretul.ro/top-3-cele-mai-interesante-si-mai-amuzante-lucruri-despre-fiecare-tara-de-pe-continentul-european/");

        }
    }

   
}
