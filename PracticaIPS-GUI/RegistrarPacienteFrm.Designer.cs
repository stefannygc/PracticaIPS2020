namespace PracticaIPS_GUI
{
    partial class RegistrarPacienteFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.NumLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.SalarioTxt = new System.Windows.Forms.TextBox();
            this.ValorServicioTxt = new System.Windows.Forms.TextBox();
            this.IdentificacionTxt = new System.Windows.Forms.TextBox();
            this.cmbTipoAfiliacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CuotaTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TarifaTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarBtn.Location = new System.Drawing.Point(330, 323);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(60, 23);
            this.EliminarBtn.TabIndex = 27;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ModificarBtn.Location = new System.Drawing.Point(259, 323);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(60, 23);
            this.ModificarBtn.TabIndex = 26;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarBtn.Location = new System.Drawing.Point(183, 323);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(60, 23);
            this.BuscarBtn.TabIndex = 25;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarBtn.Location = new System.Drawing.Point(108, 323);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(60, 23);
            this.GuardarBtn.TabIndex = 24;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // NumLiquidacionTxt
            // 
            this.NumLiquidacionTxt.Location = new System.Drawing.Point(214, 47);
            this.NumLiquidacionTxt.Name = "NumLiquidacionTxt";
            this.NumLiquidacionTxt.Size = new System.Drawing.Size(133, 20);
            this.NumLiquidacionTxt.TabIndex = 23;
            // 
            // SalarioTxt
            // 
            this.SalarioTxt.Location = new System.Drawing.Point(214, 136);
            this.SalarioTxt.Name = "SalarioTxt";
            this.SalarioTxt.Size = new System.Drawing.Size(133, 20);
            this.SalarioTxt.TabIndex = 22;
            this.SalarioTxt.Text = " ";
            // 
            // ValorServicioTxt
            // 
            this.ValorServicioTxt.Location = new System.Drawing.Point(214, 166);
            this.ValorServicioTxt.Name = "ValorServicioTxt";
            this.ValorServicioTxt.Size = new System.Drawing.Size(133, 20);
            this.ValorServicioTxt.TabIndex = 21;
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Location = new System.Drawing.Point(214, 17);
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(133, 20);
            this.IdentificacionTxt.TabIndex = 20;
            // 
            // cmbTipoAfiliacion
            // 
            this.cmbTipoAfiliacion.FormattingEnabled = true;
            this.cmbTipoAfiliacion.Items.AddRange(new object[] {
            "Contributivo",
            "Subsidiado"});
            this.cmbTipoAfiliacion.Location = new System.Drawing.Point(214, 105);
            this.cmbTipoAfiliacion.Name = "cmbTipoAfiliacion";
            this.cmbTipoAfiliacion.Size = new System.Drawing.Size(133, 21);
            this.cmbTipoAfiliacion.TabIndex = 19;
            this.cmbTipoAfiliacion.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Valor Del Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Salario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo De Afiliacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Numero De Liquidacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Identificacion";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CuotaTxt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TarifaTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.NumLiquidacionTxt);
            this.panel1.Controls.Add(this.cmbTipoAfiliacion);
            this.panel1.Controls.Add(this.SalarioTxt);
            this.panel1.Controls.Add(this.IdentificacionTxt);
            this.panel1.Controls.Add(this.ValorServicioTxt);
            this.panel1.Location = new System.Drawing.Point(48, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 229);
            this.panel1.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(154, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cuota";
            // 
            // CuotaTxt
            // 
            this.CuotaTxt.Location = new System.Drawing.Point(214, 197);
            this.CuotaTxt.Name = "CuotaTxt";
            this.CuotaTxt.Size = new System.Drawing.Size(133, 20);
            this.CuotaTxt.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tarifa";
            // 
            // TarifaTxt
            // 
            this.TarifaTxt.Location = new System.Drawing.Point(214, 77);
            this.TarifaTxt.Name = "TarifaTxt";
            this.TarifaTxt.Size = new System.Drawing.Size(133, 20);
            this.TarifaTxt.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "DATOS";
            // 
            // RegistrarPacienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 382);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.EliminarBtn);
            this.Name = "RegistrarPacienteFrm";
            this.Text = "RegistrarPacienteFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.TextBox NumLiquidacionTxt;
        private System.Windows.Forms.TextBox SalarioTxt;
        private System.Windows.Forms.TextBox ValorServicioTxt;
        private System.Windows.Forms.TextBox IdentificacionTxt;
        private System.Windows.Forms.ComboBox cmbTipoAfiliacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CuotaTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TarifaTxt;
    }
}