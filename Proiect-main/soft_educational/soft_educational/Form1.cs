using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soft_educational
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlInformatii.Visible = false;
            pnlTest.Visible = false;
        }

        private void btnInformatii_Click(object sender, EventArgs e)
        {
            pnlInformatii.Visible = true;
            pnlInformatii.Location = new Point(0, 0);
            pnlInformatii.Size = new Size(983, 540);
            btnInformatii.Visible = false;
            btnTest.Visible = false;
            lblEuropa.Visible = false;
            btnSteaguri.Visible = true;
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if(rdbLondra.Checked==true)
            {
                if(chbTallinn.Checked==true & chbRiga.Checked==true )
                {
                    if(txtVilnius.Text=="Vilnius")
                    {
                       MessageBox.Show("CORECT 3/3");
                    }
                }
               
            }
            if (rdbLondra.Checked == true)
            {
                if (chbTallinn.Checked == true & chbRiga.Checked==true )
                {
                    if (txtVilnius.Text =="Vilnius")
                    {
                        MessageBox.Show("CORECT 3/3");
                    }
                    else
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
            if (rdbLondra.Checked == true)
            {
                if (chbTallinn.Checked == false & chbRiga.Checked==false )
                {
                    if (txtVilnius.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
            if (rdbLondra.Checked == true)
            {
                if (chbTallinn.Checked == false & chbRiga.Checked == false )
                {
                    if (txtVilnius.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                    else
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (chbTallinn.Checked == false & chbRiga.Checked == false & chbViena.Checked == false)
                {
                    if (txtVilnius.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                    else
                    {
                        MessageBox.Show("GRESIT 0/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (chbTallinn.Checked == true & chbRiga.Checked == true )
                {
                    if (txtVilnius.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                    else
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (chbTallinn.Checked == true & chbRiga.Checked == true)
                {
                    if (txtVilnius.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (chbTallinn.Checked == false & chbRiga.Checked == false & chbViena.Checked == false)
                {
                    if (txtVilnius.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (chbTallinn.Checked == true & chbRiga.Checked == true )
                {
                    if (txtVilnius.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
            if (rdbLondra.Checked == true)
            {
                if (((chbTallinn.Checked == true || chbRiga.Checked == false)||(chbTallinn.Checked==false || chbRiga.Checked==true)& chbRiga.Checked==true))
                {
                    if (txtVilnius.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if(((chbTallinn.Checked == true || chbRiga.Checked == false) || (chbTallinn.Checked == false || chbRiga.Checked == true) & chbRiga.Checked==true))
                {
                    if (txtVilnius.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (((chbTallinn.Checked == true || chbRiga.Checked == false) || (chbTallinn.Checked == false || chbRiga.Checked == true) & chbRiga.Checked == true ))
                {
                    if (txtVilnius.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                    else
                    {
                        MessageBox.Show("GRESIT 0/3");
                    }
                }

            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            pnlInformatii.Visible = false;
            pnlTest.Visible = true;
            pnlTest.Location = new Point(0, 0);
            pnlTest.Size = new Size(978, 583);
            btnInformatii.Visible = false;
            btnTest.Visible = false;
            lblEuropa.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlInformatii.Visible = false;
            pnlTest.Visible = false;
            btnTest.Visible = true;
            btnInformatii.Visible = true;
            lblEuropa.Visible = true;
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            pnlInformatii.Visible = false;
            pnlTest.Visible = false;
            btnTest.Visible = true;
            btnInformatii.Visible = true;
            lblEuropa.Visible = true;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtVilnius.Clear();
            rdbEdinburgh.Checked = false;
            rdbLondra.Checked = false;
            rdbRusia.Checked = false;
            chbRiga.Checked = false;
            chbTallinn.Checked = false;
            chbViena.Checked = false;
        }

        private void btnBibiografie_Click(object sender, EventArgs e)
        {
            Bibiografie b = new Bibiografie();
            b.Show();
        }

        private void btnSteaguri_Click(object sender, EventArgs e)
        {
            Steaguri s = new Steaguri();
            s.Show();
        }
    }
}
