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
    public partial class EntradaCompra : Form
    {
        public EntradaCompra()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = string.Empty;
            txtCodigoProducto.Text = string.Empty;
            txtCodigoProveedor.Text = string.Empty;
            txtDocumentoGenerado.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtNombreProveedor.Text = string.Empty;
            txtPrecio.Text = string.Empty; 
        }

        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            StringBuilder resul = new StringBuilder();

            int buscaCliente = SDK.fBuscaCteProv(txtCodigoProveedor.Text);

            if(buscaCliente != 0)
            {
                MessageBox.Show("Error: " + SDK.rError(buscaCliente));
            }
            else
            {
                buscaCliente = SDK.fLeeDatoCteProv("CRAZONSOCIAL", resul, 512);
                txtNombreProveedor.Text = resul.ToString();
            }
        }

        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {
            StringBuilder resul = new StringBuilder();

            int buscaProducto = SDK.fBuscaProducto(txtCodigoProducto.Text);

            if(buscaProducto != 0)
            {
                MessageBox.Show("Error: " + SDK.rError(buscaProducto));
            }
            else
            {
                buscaProducto = SDK.fLeeDatoProducto("CNOMBREPRODUCTO", resul, 512);
                txtNombreProducto.Text = resul.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SDK.tDocumento sDoc = new SDK.tDocumento();
            SDK.tMovimiento sMov = new SDK.tMovimiento();
            StringBuilder lSerieDocto = new StringBuilder();
            double lFolioDocto = 0;

            if(txtNombreProducto.Text == "" || txtNombreProveedor.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Hay datos vacios en el formulario por favor revisar");
            }
            else
            {               
                int lIdDocto = 0;
                int lIdMovto = 0;
                //int lResult = 0;

                sDoc.aCodConcepto = "21";
                sDoc.aSerie = lSerieDocto.ToString();                
                sDoc.aFecha = DateTime.Today.ToString("MM/dd/yyyy");
                sDoc.aSistemaOrigen = 205;
                sDoc.aNumMoneda = 1;
                sDoc.aTipoCambio = 1;
                sDoc.aCodigoCteProv = txtCodigoProveedor.Text;

                int altaDoc = SDK.fAltaDocumento(ref lIdDocto, ref sDoc);

                if (altaDoc != 0)
                {
                    MessageBox.Show("Error alta documento: " + SDK.rError(altaDoc));
                }
                else
                {
                    sMov.aCodAlmacen = "1";
                    sMov.aCodProdSer = txtCodigoProducto.Text;
                    sMov.aUnidades = Convert.ToDouble(txtCantidad.Text);
                    sMov.aPrecio = Convert.ToDouble(txtPrecio.Text);

                    int altaMov = SDK.fAltaMovimiento(lIdDocto, ref lIdMovto, ref sMov);

                    if (altaMov != 0)
                    {
                        MessageBox.Show("Error alta movimiento: " + SDK.rError(altaMov));
                    }
                    else
                    {
                        int rAfectaDoc = SDK.fAfectaDocto_Param(sDoc.aCodConcepto, lSerieDocto.ToString(), lFolioDocto, true);

                        if (rAfectaDoc == 0)
                        {
                            MessageBox.Show("Error afecta documento parametros: " + SDK.rError(rAfectaDoc));
                        }
                        else
                        {
                            SDK.fSiguienteFolio("21", lSerieDocto, ref lFolioDocto);

                            double restaUnFolio = lFolioDocto - 1;

                            MessageBox.Show("Documento guardado con exito");
                            txtDocumentoGenerado.Text = restaUnFolio.ToString();
                        }
                    }
                }

            }
        }
    }
}
