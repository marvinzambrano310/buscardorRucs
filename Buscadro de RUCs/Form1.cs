using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscadro_de_RUCs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ErrPRuc.Clear();
            ErrRuc.Clear();
            int numero2;
            if (LblRuc.TextLength < 13 || int.TryParse(LblRuc.Text, out numero2))
            {
                this.ErrPRuc.SetError(LblRuc, "EL RUC INGRESADO ES INCORRECTO");
                LblRuc.Text = null;
                this.PbAR.Image = null;
                this.PbME.Image = null;
                this.PbFA.Image = null;
                this.PbEX.Image = null;
                this.PbGC.Image = null;
                this.PbCE.Image = null;
                this.LblDato.Visible = false;
            }
            else
            {
                String ruc = LblRuc.Text.Substring(0, 2);
                String subruc = LblRuc.Text.Substring(10);
                int dato = Convert.ToInt32(ruc);
                Console.WriteLine(subruc);
                if (subruc.Equals("001") && (dato<25))
                {
                    ErrPRuc.Clear();
                    LblDato.Text = LblRuc.Text;
                    LblDato.Visible = true;
                    if (Properties.Resources.AR.Contains(LblRuc.Text))
                    {
                        this.PbAR.Image = Properties.Resources.DFWEOWHCQZAMRNH7ALRFQYVPTU;
                    }
                    else
                    {
                        this.PbAR.Image = Properties.Resources.right_600x400_1;
                    }
                    if (Properties.Resources.CE.Contains(LblRuc.Text))
                    {
                        this.PbCE.Image = Properties.Resources.DFWEOWHCQZAMRNH7ALRFQYVPTU;
                    }
                    else
                    {
                        this.PbCE.Image = Properties.Resources.right_600x400_1;
                    }
                    if (Properties.Resources.FA.Contains(LblRuc.Text))
                    {
                        this.PbFA.Image = Properties.Resources.DFWEOWHCQZAMRNH7ALRFQYVPTU;
                    }
                    else
                    {
                        this.PbFA.Image = Properties.Resources.right_600x400_1;
                    }
                    if (Properties.Resources.EX.Contains(LblRuc.Text))
                    {
                        this.PbEX.Image = Properties.Resources.DFWEOWHCQZAMRNH7ALRFQYVPTU;
                    }
                    else
                    {
                        this.PbEX.Image = Properties.Resources.right_600x400_1;
                    }
                    if (Properties.Resources.ME.Contains(LblRuc.Text))
                    {
                        this.PbME.Image = Properties.Resources.DFWEOWHCQZAMRNH7ALRFQYVPTU;
                    }
                    else
                    {
                        this.PbME.Image = Properties.Resources.right_600x400_1;
                    }
                    if (Properties.Resources.GC.Contains(LblRuc.Text))
                    {
                        this.PbGC.Image = Properties.Resources.DFWEOWHCQZAMRNH7ALRFQYVPTU;
                    }
                    else
                    {
                        this.PbGC.Image = Properties.Resources.right_600x400_1;
                    }
                    LblRuc.Text = null;
                }
                else
                {
                    this.ErrRuc.SetError(LblRuc, "EL RUC INGRESADO NO ES VÁLIDO");
                    LblRuc.Text = null;
                    this.PbAR.Image = null;
                    this.PbME.Image = null;
                    this.PbFA.Image = null;
                    this.PbEX.Image = null;
                    this.PbGC.Image = null;
                    this.PbCE.Image = null;
                    this.LblDato.Visible = false;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
