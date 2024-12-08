
namespace inicioComercialSDK
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciaSDK = new System.Windows.Forms.Button();
            this.btnAbreEmpresa = new System.Windows.Forms.Button();
            this.btnTerminaSDK = new System.Windows.Forms.Button();
            this.cmbEmpresas = new System.Windows.Forms.ComboBox();
            this.btnCartaPorte = new System.Windows.Forms.Button();
            this.btnEntradaCompra = new System.Windows.Forms.Button();
            this.btnCierraEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciaSDK
            // 
            this.btnIniciaSDK.Location = new System.Drawing.Point(12, 12);
            this.btnIniciaSDK.Name = "btnIniciaSDK";
            this.btnIniciaSDK.Size = new System.Drawing.Size(103, 28);
            this.btnIniciaSDK.TabIndex = 0;
            this.btnIniciaSDK.Text = "Inicia SDK";
            this.btnIniciaSDK.UseVisualStyleBackColor = true;
            this.btnIniciaSDK.Click += new System.EventHandler(this.btnIniciaSDK_Click);
            // 
            // btnAbreEmpresa
            // 
            this.btnAbreEmpresa.Location = new System.Drawing.Point(193, 12);
            this.btnAbreEmpresa.Name = "btnAbreEmpresa";
            this.btnAbreEmpresa.Size = new System.Drawing.Size(103, 28);
            this.btnAbreEmpresa.TabIndex = 1;
            this.btnAbreEmpresa.Text = "Abre Empresa";
            this.btnAbreEmpresa.UseVisualStyleBackColor = true;
            this.btnAbreEmpresa.Click += new System.EventHandler(this.btnAbreEmpresa_Click);
            // 
            // btnTerminaSDK
            // 
            this.btnTerminaSDK.Location = new System.Drawing.Point(12, 99);
            this.btnTerminaSDK.Name = "btnTerminaSDK";
            this.btnTerminaSDK.Size = new System.Drawing.Size(103, 28);
            this.btnTerminaSDK.TabIndex = 2;
            this.btnTerminaSDK.Text = "Termina SDK";
            this.btnTerminaSDK.UseVisualStyleBackColor = true;
            this.btnTerminaSDK.Click += new System.EventHandler(this.btnTerminaSDK_Click);
            // 
            // cmbEmpresas
            // 
            this.cmbEmpresas.FormattingEnabled = true;
            this.cmbEmpresas.Location = new System.Drawing.Point(12, 60);
            this.cmbEmpresas.Name = "cmbEmpresas";
            this.cmbEmpresas.Size = new System.Drawing.Size(459, 21);
            this.cmbEmpresas.TabIndex = 3;
            // 
            // btnCartaPorte
            // 
            this.btnCartaPorte.Location = new System.Drawing.Point(193, 99);
            this.btnCartaPorte.Name = "btnCartaPorte";
            this.btnCartaPorte.Size = new System.Drawing.Size(74, 28);
            this.btnCartaPorte.TabIndex = 5;
            this.btnCartaPorte.Text = "Carta Porte";
            this.btnCartaPorte.UseVisualStyleBackColor = true;
            // 
            // btnEntradaCompra
            // 
            this.btnEntradaCompra.Location = new System.Drawing.Point(377, 99);
            this.btnEntradaCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntradaCompra.Name = "btnEntradaCompra";
            this.btnEntradaCompra.Size = new System.Drawing.Size(93, 28);
            this.btnEntradaCompra.TabIndex = 6;
            this.btnEntradaCompra.Text = "Entrada Compra";
            this.btnEntradaCompra.UseVisualStyleBackColor = true;
            this.btnEntradaCompra.Click += new System.EventHandler(this.btnEntradaCompra_Click);
            // 
            // btnCierraEmpresa
            // 
            this.btnCierraEmpresa.Location = new System.Drawing.Point(368, 12);
            this.btnCierraEmpresa.Name = "btnCierraEmpresa";
            this.btnCierraEmpresa.Size = new System.Drawing.Size(103, 28);
            this.btnCierraEmpresa.TabIndex = 7;
            this.btnCierraEmpresa.Text = "Cierra Empresa";
            this.btnCierraEmpresa.UseVisualStyleBackColor = true;
            this.btnCierraEmpresa.Click += new System.EventHandler(this.btnCierraEmpresa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 366);
            this.Controls.Add(this.btnCierraEmpresa);
            this.Controls.Add(this.btnEntradaCompra);
            this.Controls.Add(this.btnCartaPorte);
            this.Controls.Add(this.cmbEmpresas);
            this.Controls.Add(this.btnTerminaSDK);
            this.Controls.Add(this.btnAbreEmpresa);
            this.Controls.Add(this.btnIniciaSDK);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciaSDK;
        private System.Windows.Forms.Button btnAbreEmpresa;
        private System.Windows.Forms.Button btnTerminaSDK;
        private System.Windows.Forms.ComboBox cmbEmpresas;
        private System.Windows.Forms.Button btnCartaPorte;
        private System.Windows.Forms.Button btnEntradaCompra;
        private System.Windows.Forms.Button btnCierraEmpresa;
    }
}

