namespace formularioTarea
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chLlave = new System.Windows.Forms.CheckBox();
            this.chSerrucho = new System.Windows.Forms.CheckBox();
            this.chAlicate = new System.Windows.Forms.CheckBox();
            this.chMartillo = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubLla = new System.Windows.Forms.TextBox();
            this.txtCantidadLla = new System.Windows.Forms.TextBox();
            this.txtSubAu = new System.Windows.Forms.TextBox();
            this.txtCantidadAu = new System.Windows.Forms.TextBox();
            this.txtSubS = new System.Windows.Forms.TextBox();
            this.txtCantidadS = new System.Windows.Forms.TextBox();
            this.txtSubM = new System.Windows.Forms.TextBox();
            this.txtCantidadM = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtSubTotalDescuento = new System.Windows.Forms.TextBox();
            this.btnCalcularPagar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbdescuento15 = new System.Windows.Forms.RadioButton();
            this.rbdescuento30 = new System.Windows.Forms.RadioButton();
            this.rbdescuento50 = new System.Windows.Forms.RadioButton();
            this.rbdescuento0 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chLlave);
            this.groupBox1.Controls.Add(this.chSerrucho);
            this.groupBox1.Controls.Add(this.chAlicate);
            this.groupBox1.Controls.Add(this.chMartillo);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSubLla);
            this.groupBox1.Controls.Add(this.txtCantidadLla);
            this.groupBox1.Controls.Add(this.txtSubAu);
            this.groupBox1.Controls.Add(this.txtCantidadAu);
            this.groupBox1.Controls.Add(this.txtSubS);
            this.groupBox1.Controls.Add(this.txtCantidadS);
            this.groupBox1.Controls.Add(this.txtSubM);
            this.groupBox1.Controls.Add(this.txtCantidadM);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(51, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "SubTotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cantidad";
            // 
            // chLlave
            // 
            this.chLlave.AutoSize = true;
            this.chLlave.Location = new System.Drawing.Point(32, 170);
            this.chLlave.Name = "chLlave";
            this.chLlave.Size = new System.Drawing.Size(173, 19);
            this.chLlave.TabIndex = 18;
            this.chLlave.Text = "Llave Ajustable L. 150.00";
            this.chLlave.UseVisualStyleBackColor = true;
            this.chLlave.CheckedChanged += new System.EventHandler(this.chLlave_CheckedChanged);
            // 
            // chSerrucho
            // 
            this.chSerrucho.AutoSize = true;
            this.chSerrucho.Location = new System.Drawing.Point(32, 86);
            this.chSerrucho.Name = "chSerrucho";
            this.chSerrucho.Size = new System.Drawing.Size(138, 19);
            this.chSerrucho.TabIndex = 17;
            this.chSerrucho.Text = "Serrucho L. 120.00";
            this.chSerrucho.UseVisualStyleBackColor = true;
            this.chSerrucho.CheckedChanged += new System.EventHandler(this.chSerrucho_CheckedChanged);
            // 
            // chAlicate
            // 
            this.chAlicate.AutoSize = true;
            this.chAlicate.Location = new System.Drawing.Point(32, 127);
            this.chAlicate.Name = "chAlicate";
            this.chAlicate.Size = new System.Drawing.Size(183, 19);
            this.chAlicate.TabIndex = 16;
            this.chAlicate.Text = "Alicate Universal L. 125.00";
            this.chAlicate.UseVisualStyleBackColor = true;
            this.chAlicate.CheckedChanged += new System.EventHandler(this.chAlicate_CheckedChanged);
            // 
            // chMartillo
            // 
            this.chMartillo.AutoSize = true;
            this.chMartillo.Location = new System.Drawing.Point(32, 47);
            this.chMartillo.Name = "chMartillo";
            this.chMartillo.Size = new System.Drawing.Size(128, 19);
            this.chMartillo.TabIndex = 15;
            this.chMartillo.Text = "Martillos L. 75.00";
            this.chMartillo.UseVisualStyleBackColor = true;
            this.chMartillo.CheckedChanged += new System.EventHandler(this.chMartillo_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(368, 243);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(200, 219);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubTotal.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "SubTotal";
            // 
            // txtSubLla
            // 
            this.txtSubLla.Location = new System.Drawing.Point(368, 169);
            this.txtSubLla.Name = "txtSubLla";
            this.txtSubLla.Size = new System.Drawing.Size(100, 23);
            this.txtSubLla.TabIndex = 11;
            // 
            // txtCantidadLla
            // 
            this.txtCantidadLla.Location = new System.Drawing.Point(247, 169);
            this.txtCantidadLla.Name = "txtCantidadLla";
            this.txtCantidadLla.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadLla.TabIndex = 10;
            // 
            // txtSubAu
            // 
            this.txtSubAu.Location = new System.Drawing.Point(368, 127);
            this.txtSubAu.Name = "txtSubAu";
            this.txtSubAu.Size = new System.Drawing.Size(100, 23);
            this.txtSubAu.TabIndex = 8;
            // 
            // txtCantidadAu
            // 
            this.txtCantidadAu.Location = new System.Drawing.Point(247, 127);
            this.txtCantidadAu.Name = "txtCantidadAu";
            this.txtCantidadAu.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadAu.TabIndex = 7;
            // 
            // txtSubS
            // 
            this.txtSubS.Location = new System.Drawing.Point(368, 86);
            this.txtSubS.Name = "txtSubS";
            this.txtSubS.Size = new System.Drawing.Size(100, 23);
            this.txtSubS.TabIndex = 5;
            // 
            // txtCantidadS
            // 
            this.txtCantidadS.Location = new System.Drawing.Point(247, 86);
            this.txtCantidadS.Name = "txtCantidadS";
            this.txtCantidadS.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadS.TabIndex = 4;
            // 
            // txtSubM
            // 
            this.txtSubM.Location = new System.Drawing.Point(368, 47);
            this.txtSubM.Name = "txtSubM";
            this.txtSubM.Size = new System.Drawing.Size(100, 23);
            this.txtSubM.TabIndex = 2;
            // 
            // txtCantidadM
            // 
            this.txtCantidadM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidadM.Location = new System.Drawing.Point(247, 47);
            this.txtCantidadM.Name = "txtCantidadM";
            this.txtCantidadM.Size = new System.Drawing.Size(100, 23);
            this.txtCantidadM.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtImpuesto);
            this.groupBox2.Controls.Add(this.txtSubTotalDescuento);
            this.groupBox2.Controls.Add(this.btnCalcularPagar);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rbdescuento15);
            this.groupBox2.Controls.Add(this.rbdescuento30);
            this.groupBox2.Controls.Add(this.rbdescuento50);
            this.groupBox2.Controls.Add(this.rbdescuento0);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(584, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Impuesto";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(86, 195);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 23);
            this.txtImpuesto.TabIndex = 22;
            // 
            // txtSubTotalDescuento
            // 
            this.txtSubTotalDescuento.Location = new System.Drawing.Point(86, 166);
            this.txtSubTotalDescuento.Name = "txtSubTotalDescuento";
            this.txtSubTotalDescuento.Size = new System.Drawing.Size(100, 23);
            this.txtSubTotalDescuento.TabIndex = 21;
            // 
            // btnCalcularPagar
            // 
            this.btnCalcularPagar.Location = new System.Drawing.Point(48, 267);
            this.btnCalcularPagar.Name = "btnCalcularPagar";
            this.btnCalcularPagar.Size = new System.Drawing.Size(103, 47);
            this.btnCalcularPagar.TabIndex = 19;
            this.btnCalcularPagar.Text = "Total a Pagar";
            this.btnCalcularPagar.UseVisualStyleBackColor = true;
            this.btnCalcularPagar.Click += new System.EventHandler(this.btnCalcularPagar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(86, 225);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total";
            // 
            // rbdescuento15
            // 
            this.rbdescuento15.AutoSize = true;
            this.rbdescuento15.Location = new System.Drawing.Point(22, 85);
            this.rbdescuento15.Name = "rbdescuento15";
            this.rbdescuento15.Size = new System.Drawing.Size(52, 19);
            this.rbdescuento15.TabIndex = 3;
            this.rbdescuento15.TabStop = true;
            this.rbdescuento15.Text = "15%";
            this.rbdescuento15.UseVisualStyleBackColor = true;
            // 
            // rbdescuento30
            // 
            this.rbdescuento30.AutoSize = true;
            this.rbdescuento30.Location = new System.Drawing.Point(22, 126);
            this.rbdescuento30.Name = "rbdescuento30";
            this.rbdescuento30.Size = new System.Drawing.Size(52, 19);
            this.rbdescuento30.TabIndex = 2;
            this.rbdescuento30.TabStop = true;
            this.rbdescuento30.Text = "30%";
            this.rbdescuento30.UseVisualStyleBackColor = true;
            // 
            // rbdescuento50
            // 
            this.rbdescuento50.AutoSize = true;
            this.rbdescuento50.Location = new System.Drawing.Point(22, 171);
            this.rbdescuento50.Name = "rbdescuento50";
            this.rbdescuento50.Size = new System.Drawing.Size(52, 19);
            this.rbdescuento50.TabIndex = 1;
            this.rbdescuento50.TabStop = true;
            this.rbdescuento50.Text = "50%";
            this.rbdescuento50.UseVisualStyleBackColor = true;
            // 
            // rbdescuento0
            // 
            this.rbdescuento0.AutoSize = true;
            this.rbdescuento0.Location = new System.Drawing.Point(22, 48);
            this.rbdescuento0.Name = "rbdescuento0";
            this.rbdescuento0.Size = new System.Drawing.Size(45, 19);
            this.rbdescuento0.TabIndex = 0;
            this.rbdescuento0.TabStop = true;
            this.rbdescuento0.Text = "0%";
            this.rbdescuento0.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(293, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ferreteria los \"Proceres\"";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(51, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(28, 26);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 433);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario- Jose Colindres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubLla;
        private System.Windows.Forms.TextBox txtCantidadLla;
        private System.Windows.Forms.TextBox txtSubAu;
        private System.Windows.Forms.TextBox txtCantidadAu;
        private System.Windows.Forms.TextBox txtSubS;
        private System.Windows.Forms.TextBox txtCantidadS;
        private System.Windows.Forms.TextBox txtSubM;
        private System.Windows.Forms.TextBox txtCantidadM;
        private System.Windows.Forms.CheckBox chLlave;
        private System.Windows.Forms.CheckBox chSerrucho;
        private System.Windows.Forms.CheckBox chAlicate;
        private System.Windows.Forms.CheckBox chMartillo;
        private System.Windows.Forms.Button btnCalcularPagar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbdescuento15;
        private System.Windows.Forms.RadioButton rbdescuento30;
        private System.Windows.Forms.RadioButton rbdescuento50;
        private System.Windows.Forms.RadioButton rbdescuento0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtSubTotalDescuento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImpuesto;
    }
}

