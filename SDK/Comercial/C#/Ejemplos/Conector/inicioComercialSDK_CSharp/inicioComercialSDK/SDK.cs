using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace inicioComercialSDK
{
    class SDK
    {
        #region CONSTANTES
        public class constantes // Declaración de constantes
        {
            public const int kLongFecha = 24;
            public const int kLongSerie = 12;
            public const int kLongCodigo = 31;
            public const int kLongNombre = 61;
            public const int kLongReferencia = 21;
            public const int kLongDescripcion = 61;
            public const int kLongCuenta = 101;
            public const int kLongMensaje = 3001;
            public const int kLongNombreProducto = 256;
            public const int kLongAbreviatura = 4;
            public const int kLongCodValorClasif = 4;
            public const int kLongDenComercial = 51;
            public const int kLongRepLegal = 51;
            public const int kLongTextoExtra = 51;
            public const int kLongRFC = 21;
            public const int kLongCURP = 21;
            public const int kLongDesCorta = 21;
            public const int kLongNumeroExtInt = 7;
            public const int kLongNumeroExpandido = 31;
            public const int kLongCodigoPostal = 7;
            public const int kLongTelefono = 16;
            public const int kLongEmailWeb = 51;

            public const int kLongSelloSat = 176;
            public const int kLonSerieCertSAT = 21;
            public const int kLongFechaHora = 36;
            public const int kLongSelloCFDI = 176;
            public const int kLongCadOrigComplSAT = 501;
            public const int kLongitudUUID = 37;
            public const int kLongitudRegimen = 101;
            public const int kLongitudMoneda = 61;
            public const int kLongitudFolio = 17;
            public const int kLongitudMonto = 31;
            public const int kLogitudLugarExpedicion = 401;
        }
        #endregion

        #region ESTRUTURAS
        // Eestructura de documentos
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tDocumento
        {

            public Double aFolio;
            public int aNumMoneda;
            public Double aTipoCambio;
            public Double aImporte;
            public Double aDescuentoDoc1;
            public Double aDescuentoDoc2;
            public int aSistemaOrigen;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodConcepto;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongSerie)]
            public String aSerie;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public String aFecha;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodigoCteProv;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodigoAgente;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongReferencia)]
            public String aReferencia;
            public int aAfecta;
            public int aGasto1;
            public int aGasto2;
            public int aGasto3;

        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct RegLlaveDoc
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodConcepto;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongSerie)]
            public String aSerie;
            public double folio;
        }

        // Eestructura de movimiento

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tMovimiento
        {
            public int aConsecutivo;
            public Double aUnidades;
            public Double aPrecio;
            public Double aCosto;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodProdSer;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodAlmacen;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongReferencia)]
            public String aReferencia;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String aCodClasificacion;
        }

        // Estructura de cliente Provedor
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tCteProv
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String cCodigoCliente;//[ kLongCodigo + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongNombre)]
            public String cRazonSocial;//[ kLongNombre + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public String cFechaAlta;//[ kLongFecha + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongRFC)]
            public String cRFC;//[ kLongRFC + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCURP)]
            public String cCURP;//[ kLongCURP + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongDenComercial)]
            public String cDenComercial;//[ kLongDenComercial + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongRepLegal)]
            public String cRepLegal;//[ kLongRepLegal + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongNombre)]
            public String cNombreMoneda;//[ kLongNombre + 1 ];
            public int cListaPreciosCliente;
            public double cDescuentoMovto;
            public int cBanVentaCredito; // 0 = No se permite venta a crédito, 1 = Se permite venta a crédito
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionCliente1;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionCliente2;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionCliente3;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionCliente4;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionCliente5;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionCliente6;//[ kLongCodValorClasif + 1 ];
            public int cTipoCliente; // 1 - Cliente, 2 - Cliente/Proveedor, 3 - Proveedor
            public int cEstatus; // 0. Inactivo, 1. Activo
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public String cFechaBaja;//[ kLongFecha + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public String cFechaUltimaRevision;//[ kLongFecha + 1 ];
            public double cLimiteCreditoCliente;
            public int cDiasCreditoCliente;
            public int cBanExcederCredito; // 0 = No se permite exceder crédito, 1 = Se permite exceder el crédito
            public double cDescuentoProntoPago;
            public int cDiasProntoPago;
            double cInteresMoratorio;
            public int cDiaPago;
            public int cDiasRevision;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongDesCorta)]
            public String cMensajeria;//[ kLongDesCorta + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongDescripcion)]
            public String cCuentaMensajeria;//[ kLongDescripcion + 1 ];
            public int cDiasEmbarqueCliente;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String cCodigoAlmacen;//[ kLongCodigo + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String cCodigoAgenteVenta;//[ kLongCodigo + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public String cCodigoAgenteCobro;//[ kLongCodigo + 1 ];
            public int cRestriccionAgente;
            public double cImpuesto1;
            public double cImpuesto2;
            public double cImpuesto3;
            public double cRetencionCliente1;
            public double cRetencionCliente2;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionProveedor1;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionProveedor2;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionProveedor3;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionProveedor4;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionProveedor5;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public String cCodigoValorClasificacionProveedor6;//[ kLongCodValorClasif + 1 ];
            public double cLimiteCreditoProveedor;
            public int cDiasCreditoProveedor;
            public int cTiempoEntrega;
            public int cDiasEmbarqueProveedor;
            public double cImpuestoProveedor1;
            public double cImpuestoProveedor2;
            public double cImpuestoProveedor3;
            public double cRetencionProveedor1;
            public double cRetencionProveedor2;
            public int cBanInteresMoratorio; // 0 = No se le calculan intereses moratorios al cliente, 1 = Si se le calculan intereses moratorios al cliente.
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongTextoExtra)]
            public String cTextoExtra1;//[ kLongTextoExtra + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongTextoExtra)]
            public String cTextoExtra2;//[ kLongTextoExtra + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongTextoExtra)]
            public String cTextoExtra3;//[ kLongTextoExtra + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongTextoExtra)]
            public String cFechaExtra;//[ kLongFecha + 1 ];
            public double cImporteExtra1;
            public double cImporteExtra2;
            public double cImporteExtra3;
            public double cImporteExtra4;

        }

        //Estrutura de productos
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tProduto
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public string cCodigoProducto;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongNombre)]
            public string cNombreProducto;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongNombreProducto)]
            public string cDescripcionProducto;
            public int cTipoProducto; // 1 = Producto, 2 = Paquete, 3 = Servicio
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public string cFechaAltaProducto;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public string cFechaBaja;
            public int cStatusProducto; // 0 - Baja Lógica, 1 - Alta
            public int cControlExistencia;
            public int cMetodoCosteo; // 1 = Costo Promedio en Base a Entradas, 2 = Costo Promedio en Base a Entradas Almacen, 3 = Último costo, 4 = UEPS, 5 = PEPS, 6 = Costo específico, 7 = Costo Estandar
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public string cCodigoUnidadBase;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public string cCodigoUnidadNoConvertible;
            public double cPrecio1;
            public double cPrecio2;
            public double cPrecio3;
            public double cPrecio4;
            public double cPrecio5;
            public double cPrecio6;
            public double cPrecio7;
            public double cPrecio8;
            public double cPrecio9;
            public double cPrecio10;
            public double cImpuesto1;
            public double cImpuesto2;
            public double cImpuesto3;
            public double cRetencion1;
            public double cRetencion2;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongNombre)]
            public string cNombreCaracteristica1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongNombre)]
            public string cNombreCaracteristica2;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongNombre)]
            public string cNombreCaracteristica3;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public string cCodigoValorClasificacion1;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public string cCodigoValorClasificacion2;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public string cCodigoValorClasificacion3;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public string cCodigoValorClasificacion4;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public string cCodigoValorClasificacion5;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodValorClasif)]
            public string cCodigoValorClasificacion6;//[ kLongCodValorClasif + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongTextoExtra)]
            public string cTextoExtra1;//[ kLongTextoExtra + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongTextoExtra)]
            public string cTextoExtra2;//[ kLongTextoExtra + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongTextoExtra)]
            public string cTextoExtra3;//[ kLongTextoExtra + 1 ];
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public string cFechaExtra;//[ kLongFecha + 1 ];
            public double cImporteExtra1;
            public double cImporteExtra2;
            public double cImporteExtra3;
            public double cImporteExtra4;
        }

        //Estructura de SeriesCapas
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
        public struct tSeriesCapas
        {
            public double aUnidades;
            public double aTipoCambio;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongCodigo)]
            public string aSeries;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongDescripcion)]
            public string aPedimento;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongDescripcion)]
            public string aAgencia;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public string aFechaPedimento;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongDescripcion)]
            public string aNumeroLote;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public string aFechaFabricacion;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = constantes.kLongFecha)]
            public string aFechaCaducidad;
        }



        #endregion

        #region METODOS DE WINDOWS
        [DllImport("KERNEL32")]
        public static extern int SetCurrentDirectory(string pPtrDirActual);
        #endregion

        #region METODOS DE CONEXION
        [DllImport("MGWServicios.dll")]
        public static extern void fTerminaSDK();

        [DllImport("MGWServicios.DLL")]
        public static extern int fSetNombrePAQ(String aNombrePAQ);

        [DllImport("MGWServicios.dll")]
        public static extern int fAbreEmpresa(string Directorio);

        [DllImport("MGWServicios.dll")]
        public static extern void fCierraEmpresa();

        [DllImport("MGWServicios.dll")]
        public static extern Int32 fPosPrimerEmpresa(ref int lIdEmpresa, StringBuilder lNombreEmpresa, StringBuilder lDirectorioEmpresa);

        [DllImport("MGWServicios.dll")]
        public static extern Int32 fPosSiguienteEmpresa(ref int lIdEmpresa, StringBuilder lNombreEmpresa, StringBuilder lDirectorioEmpresa);
        #endregion

        public static string fconexion(EventArgs e)//Metodo que me pasó Ray para la conexión
        {

            //StringBuilder sMensaje = new StringBuilder(512);
            string sMensaje = "";
            int lError;

            string szRegKeySistema = @"SOFTWARE\\Computación en Acción, SA CV\\CONTPAQ I COMERCIAL";
            string sNombrePAQ = "CONTPAQ I COMERCIAL";

            RegistryKey keySistema = Registry.LocalMachine.OpenSubKey(szRegKeySistema);
            object lEntrada = keySistema.GetValue("DirectorioBase");

            // SetCurrentDirectory
            long lResult;
            lResult = SetCurrentDirectory(lEntrada.ToString());

            lError = fSetNombrePAQ(sNombrePAQ);
            if (lError != 0)
            {
                rError(lError);
            }
            else
            {
                sMensaje = "Se abrió el SDK correctamente.";
            }

            return sMensaje;
        }

        public static string fNoConexion(EventArgs e)
        {
            string mensajeNo = "No has iniciado SDK";

            return mensajeNo;
        }

        public static List<string> lista_empresas()//Método para listar las empresas
        {
            int lError;
            List<string> lempresas = new List<string>();
            StringBuilder aNombreEmpresa = new StringBuilder(255);
            StringBuilder aDirectorioEmpresa = new StringBuilder(255);

            int aldEmpresa = 0;
            lError = fPosPrimerEmpresa(ref aldEmpresa, aNombreEmpresa, aDirectorioEmpresa);
            lempresas.Add(aDirectorioEmpresa.ToString());

            do
            {
                lError = fPosSiguienteEmpresa(ref aldEmpresa, aNombreEmpresa, aDirectorioEmpresa);
                if (lError == 2)
                {
                    break;
                }
                else
                {
                    lempresas.Add(aDirectorioEmpresa.ToString());
                }
            } while (lError == 0);



            return lempresas;
        }



        #region METODOS DE DOCUMENTOS
        [DllImport("MGWServicios.dll")]
        public static extern Int32 fAltaDocumento(ref Int32 aIdDocumento, ref tDocumento atDocumento);

        [DllImport("MGWServicios.dll")]
        public static extern Int32 fSiguienteFolio([MarshalAs(UnmanagedType.LPStr)] string aCodigoConcepto,
                                                    [MarshalAs(UnmanagedType.LPStr)] StringBuilder aSerie,
                                                    ref double aFolio);
        [DllImport("MGWServicios.dll")]
        public static extern int fAfectaDocto_Param(string aCodConcepto, string aSerie, double aFolio, bool aAfecta);

        [DllImport("MGWServicios.dll")]
        public static extern int fEmitirDocumento([MarshalAs(UnmanagedType.LPStr)] string aCodConcepto, [MarshalAs(UnmanagedType.LPStr)] string aSerie,
        double aFolio, [MarshalAs(UnmanagedType.LPStr)] string aPassword, [MarshalAs(UnmanagedType.LPStr)] string aArchivoAdicional);

        [DllImport("MGWServicios.dll")]
        public static extern int fEntregEnDiscoXML(string aCodConcepto, string aSerie, double aFolio, int aFormato, string aFormatoAmig);
        [DllImport("MGWServicios.DLL")]
        public static extern int fBuscarDocumento(string aCodConcepto, string aSerie, string aFolio);

        [DllImport("MGWServicios.dll")]
        public static extern int fBuscaDocumento(ref RegLlaveDoc aLlaveDocto);

        [DllImport("MGWServicios.dll")]
        public static extern Int32 fSaldarDocumento(ref RegLlaveDoc astDocAPagar, ref RegLlaveDoc astDocPago, double importe, int moneda, string aFecha);

        [DllImport("MGWServicios.dll")]
        public static extern Int32 fAltaDocumentoCargoAbono(ref tDocumento aDocumento);
        [DllImport("MGWServicios.DLL")]
        public static extern int fGetDatosCFDI(StringBuilder aSerieCertEmisor,
                                                 StringBuilder aFolioFiscalUUID,
                                                 StringBuilder aSerieCertSAT,
                                                 StringBuilder aFechaHora,
                                                 StringBuilder aSelloDigCFDI,
                                                 StringBuilder aSelloSAAT,
                                                 StringBuilder aCadOrigComplSAT,
                                                 StringBuilder aRegimen,
                                                 StringBuilder aLugarExpedicion,
                                                 StringBuilder aMoneda,
                                                 StringBuilder aFolioFiscalOrig,
                                                 StringBuilder aSerieFolioFiscalOrig,
                                                 StringBuilder aFechaFolioFiscalOrig,
                                                 StringBuilder aMontoFolioFiscalOrig);

        [DllImport("MGWServicios.dll")]
        public static extern int fBorrarAsociacion_Param(string aCodConcepto_Pagar, string aSerie_Pagar, double aFolio_Pagar, string aCodConcepto_Pago, string aSerie_Pago, double aFolio_Pago);

        [DllImport("MGWServicios.dll")]
        public static extern int fSetDatoConceptoDocto(StringBuilder aCampo, StringBuilder aValor);

        [DllImport("MGWServicios.dll")]
        public static extern int fGuardaConceptoDocto();

        [DllImport("MGWServicios.dll")]
        public static extern int fEditaConceptoDocto();

        [DllImport("MGWServicios.dll", EntryPoint = "fDocumentoImpreso")]
        public static extern int fDocumentoImpreso(ref bool aImpreso);
        #endregion

        #region METODOS DE MOVIMIENTOS
        [DllImport("MGWServicios.dll")]
        public static extern Int32 fAltaMovimiento(Int32 aIdDocumento, ref Int32 aIdMovimiento, ref tMovimiento atMovimiento);


        [DllImport("MGWServicios.DLL")]
        public static extern int fEditarDocumento();

        [DllImport("MGWServicios.DLL")]
        public static extern int fSetDatoDocumento(string aCampo, string aValor);

        [DllImport("MGWServicios.DLL")]
        public static extern int fLeeDatoDocumento(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.DLL")]
        public static extern int fGuardaDocumento();


        [DllImport("MGWServicios.DLL")]
        public static extern int fBuscarIdMovimiento(Int32 aIdMovimiento);


        [DllImport("MGWServicios.DLL")]
        public static extern int fEditarMovimiento();


        [DllImport("MGWServicios.DLL")]
        public static extern int fGuardaMovimiento();


        [DllImport("MGWServicios.DLL")]
        public static extern int fSetDatoMovimiento(string aCampo, string aValor);

        [DllImport("MGWServicios.DLL")]
        public static extern int fLeeDatoMovimiento(string aCampo, StringBuilder aValor, int aLen);

        [DllImport("MGWServicios.DLL")]/////////////////
        public static extern Int32 fAltaMovimientoIdSeriesCapas(int aIdSeriesCapsa, int aIdMovimiento, ref tSeriesCapas lSeries);

        [DllImport("MGWServicios.DLL")]/////////////////////////
        public static extern Int32 fCalculaMovtoSerieCapa(int lIdMovimiento);

        [DllImport("MGWServicios.dll")]
        public static extern int fAltaMovimientoSeriesCapas_Param(string aIdMovimiento, string aUnidades, string aTipoCambio, string aSeries, string aPedimento, string aAgencia, string aFechaPedimento, string aNumeroLote, string aFechaFabricacion, string aFechaCaducidad);
        #endregion

        #region METODOS DE PRODUCTOS

        [DllImport("MGWServicios.dll")]
        public static extern int fAltaProducto(ref int aIdProducto, ref tProduto astProducto);

        [DllImport("MGWServicios.dll")]
        public static extern int fBuscaProducto(string aCodProducto);

        [DllImport("MGWServicios.dll")]
        public static extern int fLeeDatoProducto(string aCodProducto, StringBuilder aNomProducto, int aLong);//-----------

        [DllImport("MGWServicios.dll")]//----------
        public static extern int fActualizaProducto(ref int aCodigoProducto, ref tProduto astProducto);

        [DllImport("MGWServicios.dll")]
        public static extern int fEditaProducto();

        [DllImport("MGWServicios.dll")]
        public static extern int fSetDatoProducto(String aCampo, String aValor);

        [DllImport("MGWServicios.dll")]
        public static extern int fGuardaProducto();

        [DllImport("MGWServicios.dll")]
        public static extern int fEliminarProducto(string aCodigoProducto);
        [DllImport("MGWServicios.dll")]
        public static extern int fRegresaExistencia(string aCodigoProducto, string aCodigoAlmacen, string aAnio, string aMes, string aDia, ref double aExistencia);
        [DllImport("MGWServicios.dll")]
        public static extern Int32 fRegresaExistenciaLotePedimento(string aCodigoProducto, string aCodigoAlmacen, string aPedimento, string aLote, ref double aExistencia);
        #endregion

        #region METODOS DE CLIENTES

        [DllImport("MGWServicios.dll")]
        public static extern int fAltaCteProv(ref int aIdCliente, ref tCteProv astCliente);

        [DllImport("MGWServicios.DLL")]
        public static extern int fBuscaCteProv(string aCodCteProv);

        [DllImport("MGWServicios.DLL")]
        public static extern int fLeeDatoCteProv(string aCampo, StringBuilder aValr, int aLen);

        [DllImport("MGWServicios.DLL")]
        public static extern int fEditaCteProv();

        [DllImport("MGWServicios.DLL")]
        public static extern int fSetDatoCteProv(string aCampo, string aValor);

        [DllImport("MGWServicios.DLL")]
        public static extern int fGuardaCteProv();

        [DllImport("MGWServicios.DLL")]
        public static extern int fBorraCteProv(string aCodCteProv);

        [DllImport("MGWServicios.DLL")]
        public static extern int fEliminarCteProv(string aCodigoCteProv);

        #endregion

        #region METODOS DE ERRORES
        [DllImport("MGWServicios.dll")]
        public static extern void fError(int NumeroError, StringBuilder Mensaje, int Longitud);

        // Función para el manejo de errores en SDK
        public static string rError(int iError)
        {
            StringBuilder sMensaje = new StringBuilder(512);

            if (iError != 0)
            {
                fError(iError, sMensaje, 512);

            }
            return sMensaje.ToString();
        }
        #endregion


        #region METODO DE BUSCA Y MUESTRA PRODUCTO
        //******************

        #endregion
    }
}
