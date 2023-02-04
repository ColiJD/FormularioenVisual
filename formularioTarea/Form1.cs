using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularioTarea
{
    public partial class Form1 : Form
    {
        
        double subTotal = 0.0;

           

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; 
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bitmap img = new Bitmap(@"C:\Users\colin\Desktop\Primer Parcial 2023\ProgramacionVisual\formularioTarea\formularioTarea\bin\Debug\img\fondo.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            noVisibles();
            



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void chMartillo_CheckedChanged(object sender, EventArgs e)
        {
            if (chMartillo.Checked)
            {
                txtCantidadM.Enabled = true;
                txtCantidadM.Focus();           
            }
            else { 
                txtCantidadM.Enabled=false;
                txtCantidadM.Clear();   
            }
        }

        private void chSerrucho_CheckedChanged(object sender, EventArgs e)
        {
            if (chSerrucho.Checked)
            {
                txtCantidadS.Enabled = true;
                txtCantidadS.Focus();
                
            }
            else
            {
                txtCantidadS.Enabled = false;
                txtCantidadS.Clear();
                
            }
        }

        private void chAlicate_CheckedChanged(object sender, EventArgs e)
        {
            if (chAlicate.Checked)
            {
                txtCantidadAu.Enabled = true;
                txtCantidadAu.Focus();
            }
            else
            {
                txtCantidadAu.Enabled = false;
                txtCantidadAu.Clear();
            }
        }

        private void chLlave_CheckedChanged(object sender, EventArgs e)
        {
            if (chLlave.Checked)
            {
                txtCantidadLla.Enabled = true;
                txtCantidadLla.Focus();
            }
            else
            {
                txtCantidadLla.Enabled = false;
                txtCantidadLla.Clear();
            }
        }
        private void noVisibles() {
            txtSubM.Enabled = false;
            txtSubS.Enabled = false;
            txtSubAu.Enabled = false;
            txtSubLla.Enabled = false;
            txtSubTotal.Enabled = false;
            txtSubTotalDescuento.Enabled = false;
            txtTotal.Enabled = false;
            txtCantidadM.Enabled = false;
            txtCantidadS.Enabled = false;
            txtCantidadLla.Enabled = false;
            txtCantidadAu.Enabled = false;
            txtImpuesto.Enabled = false;
            

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var m = txtCantidadM.Text;
            var s = txtCantidadS.Text;
            var Au = txtCantidadAu.Text;
            var lla = txtCantidadLla.Text;
            double martillo;
            double serrucho;
            double alicate;
            double llaveU;


            if (m == "")
            {   
                martillo = 0;
            }
            else {
                martillo = Convert.ToDouble(m);
                martillo *= 75;
                
            }
            if (s == "")
            {
                serrucho = 0;
            }
            else {
                serrucho = Convert.ToDouble(s);
                serrucho *=  120;
            }
            if (Au == "")
            {
                alicate = 0;
            }
            else
            {
                alicate = Convert.ToDouble(Au);
                alicate *=  125;
            }
            if (lla == "")
            {
                llaveU = 0;
            }
            else
            {
                llaveU = Convert.ToDouble(lla);
                llaveU *= 150;
            }
            subTotal = martillo + serrucho + alicate + llaveU;
            txtSubTotal.Text = subTotal.ToString("0.##");

            txtSubM.Text = martillo.ToString();
            txtSubS.Text = serrucho.ToString();
            txtSubAu.Text = alicate.ToString();
            txtSubLla.Text = llaveU.ToString();
        }

        private void btnCalcularPagar_Click(object sender, EventArgs e)
        {
            double descuento = 0;
            double Impuesto = 0;
            double total = 0;

            if (rbdescuento0.Checked) {
                descuento = subTotal * 0;
            }
            if (rbdescuento15.Checked) {
                descuento = subTotal * 0.15;
            }
            if (rbdescuento30.Checked) {
                descuento = subTotal * 0.30;
            }
            if (rbdescuento50.Checked)
            {
                descuento = subTotal * 0.50;
            }

            Impuesto = (subTotal - descuento) * 0.15;
            total = (subTotal - descuento + Impuesto );
            txtSubTotalDescuento.Text = descuento.ToString("0.##");
            txtImpuesto.Text = Impuesto.ToString("0.##");
            txtTotal.Text = total.ToString("0.##");
        }
        
    }

}
