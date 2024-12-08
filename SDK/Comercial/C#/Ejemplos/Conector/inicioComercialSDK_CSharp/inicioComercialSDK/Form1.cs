using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inicioComercialSDK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            btnAbreEmpresa.Enabled = false;
            btnCierraEmpresa.Enabled = false;
            btnCartaPorte.Enabled = false;
            btnEntradaCompra.Enabled = false;
            btnTerminaSDK.Enabled = false;
        }

        private bool btnIniciaPress = false;
        private void btnIniciaSDK_Click(object sender, EventArgs e)
        {
            btnIniciaPress = true;
            SDK.fconexion(e);
            MessageBox.Show("SDK Iniciado");
            cmbEmpresas.DataSource = SDK.lista_empresas();
            btnTerminaSDK.Enabled = true;
            btnAbreEmpresa.Enabled = true;
        }

        private void btnTerminaSDK_Click(object sender, EventArgs e)
        {
            if (btnIniciaPress == true)
            {
                SDK.fCierraEmpresa();
                SDK.fTerminaSDK();
                MessageBox.Show("Aplicación SDK Finalizada..");
                Close();
            }
            else
            {
                MessageBox.Show("No iniciaste SDK");
                Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnIniciaPress)
            {
                SDK.fCierraEmpresa();
                SDK.fTerminaSDK();
            }                                                             
        }

        private void btnAbreEmpresa_Click(object sender, EventArgs e)
        {
            if (btnIniciaPress)
            {
                Object selecItem = cmbEmpresas.SelectedItem;
                int abreEmpresa = SDK.fAbreEmpresa(selecItem.ToString());

                if(abreEmpresa != 0)
                {
                    MessageBox.Show("Error: " + SDK.rError(abreEmpresa));
                }
                else
                {
                    MessageBox.Show("Se ha abierto la empresa " + selecItem.ToString());
                    btnCierraEmpresa.Enabled = true;
                    btnCartaPorte.Enabled = true;
                    btnEntradaCompra.Enabled = true;
                }

                
            }
            else
            {
                MessageBox.Show("Primero inicia SDK");
            }
        }

        private void btnEntradaCompra_Click(object sender, EventArgs e)
        {
            EntradaCompra enCom = new EntradaCompra();
            enCom.Show();
        }

        private void btnCierraEmpresa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrará la empresa " + cmbEmpresas.SelectedItem);
            SDK.fCierraEmpresa();
            cmbEmpresas.Text = "";
            btnCierraEmpresa.Enabled = false;
        }
    }
}
