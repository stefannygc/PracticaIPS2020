namespace PracticaIPS_GUI
{
    partial class ConsultarFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.TotalSubsidiadoTxt = new System.Windows.Forms.TextBox();
            this.TotalHombres = new System.Windows.Forms.Label();
            this.TodosTxt = new System.Windows.Forms.TextBox();
            this.Todos = new System.Windows.Forms.Label();
            this.cmbConsultar = new System.Windows.Forms.ComboBox();
            this.TotalContributivoTxt = new System.Windows.Forms.TextBox();
            this.TotalizarMujeresTxt = new System.Windows.Forms.Label();
            this.ValorTotalLiquiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValorLiContributivoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValorLiquiSubsidiadioTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtgPaciente = new System.Windows.Forms.DataGridView();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tipo De Consulta";
            // 
            // TotalSubsidiadoTxt
            // 
            this.TotalSubsidiadoTxt.Location = new System.Drawing.Point(677, 300);
            this.TotalSubsidiadoTxt.Name = "TotalSubsidiadoTxt";
            this.TotalSubsidiadoTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalSubsidiadoTxt.TabIndex = 29;
            // 
            // TotalHombres
            // 
            this.TotalHombres.AutoSize = true;
            this.TotalHombres.BackColor = System.Drawing.Color.Transparent;
            this.TotalHombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHombres.Location = new System.Drawing.Point(494, 302);
            this.TotalHombres.Name = "TotalHombres";
            this.TotalHombres.Size = new System.Drawing.Size(173, 15);
            this.TotalHombres.TabIndex = 28;
            this.TotalHombres.Text = "Liquidaciones Subsidiado";
            // 
            // TodosTxt
            // 
            this.TodosTxt.Location = new System.Drawing.Point(677, 248);
            this.TodosTxt.Name = "TodosTxt";
            this.TodosTxt.Size = new System.Drawing.Size(100, 20);
            this.TodosTxt.TabIndex = 27;
            // 
            // Todos
            // 
            this.Todos.AutoSize = true;
            this.Todos.BackColor = System.Drawing.Color.Transparent;
            this.Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todos.Location = new System.Drawing.Point(512, 249);
            this.Todos.Name = "Todos";
            this.Todos.Size = new System.Drawing.Size(155, 15);
            this.Todos.TabIndex = 26;
            this.Todos.Text = "Total De Liquidaciones";
            // 
            // cmbConsultar
            // 
            this.cmbConsultar.FormattingEnabled = true;
            this.cmbConsultar.Items.AddRange(new object[] {
            "Total De Liquidaciones",
            "Liquidaciones Contributivo",
            "Liquidaciones Subsidiado"});
            this.cmbConsultar.Location = new System.Drawing.Point(169, 332);
            this.cmbConsultar.Name = "cmbConsultar";
            this.cmbConsultar.Size = new System.Drawing.Size(184, 21);
            this.cmbConsultar.TabIndex = 25;
            // 
            // TotalContributivoTxt
            // 
            this.TotalContributivoTxt.Location = new System.Drawing.Point(677, 274);
            this.TotalContributivoTxt.Name = "TotalContributivoTxt";
            this.TotalContributivoTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalContributivoTxt.TabIndex = 24;
            // 
            // TotalizarMujeresTxt
            // 
            this.TotalizarMujeresTxt.AutoSize = true;
            this.TotalizarMujeresTxt.BackColor = System.Drawing.Color.Transparent;
            this.TotalizarMujeresTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalizarMujeresTxt.Location = new System.Drawing.Point(494, 276);
            this.TotalizarMujeresTxt.Name = "TotalizarMujeresTxt";
            this.TotalizarMujeresTxt.Size = new System.Drawing.Size(177, 15);
            this.TotalizarMujeresTxt.TabIndex = 23;
            this.TotalizarMujeresTxt.Text = "Liquidaciones Contributivo";
            // 
            // ValorTotalLiquiTxt
            // 
            this.ValorTotalLiquiTxt.Location = new System.Drawing.Point(918, 337);
            this.ValorTotalLiquiTxt.Name = "ValorTotalLiquiTxt";
            this.ValorTotalLiquiTxt.Size = new System.Drawing.Size(100, 20);
            this.ValorTotalLiquiTxt.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(730, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Valor Total Liquidaciones";
            // 
            // ValorLiContributivoTxt
            // 
            this.ValorLiContributivoTxt.Location = new System.Drawing.Point(918, 363);
            this.ValorLiContributivoTxt.Name = "ValorLiContributivoTxt";
            this.ValorLiContributivoTxt.Size = new System.Drawing.Size(100, 20);
            this.ValorLiContributivoTxt.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(694, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Valor Liquidaciones Contributivo ";
            // 
            // ValorLiquiSubsidiadioTxt
            // 
            this.ValorLiquiSubsidiadioTxt.Location = new System.Drawing.Point(918, 389);
            this.ValorLiquiSubsidiadioTxt.Name = "ValorLiquiSubsidiadioTxt";
            this.ValorLiquiSubsidiadioTxt.Size = new System.Drawing.Size(100, 20);
            this.ValorLiquiSubsidiadioTxt.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(702, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Valor Liquidaciones Subsidiado";
            // 
            // DtgPaciente
            // 
            this.DtgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPaciente.Location = new System.Drawing.Point(12, 12);
            this.DtgPaciente.Name = "DtgPaciente";
            this.DtgPaciente.Size = new System.Drawing.Size(1020, 219);
            this.DtgPaciente.TabIndex = 38;
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarBtn.Image = global::PracticaIPS_GUI.Properties.Resources.icontexto_search_17_icon_icons_com_76913;
            this.ConsultarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConsultarBtn.Location = new System.Drawing.Point(379, 320);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(76, 59);
            this.ConsultarBtn.TabIndex = 22;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            this.ConsultarBtn.Click += new System.EventHandler(this.ConsultarBtn_Click);
            // 
            // ConsultarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 461);
            this.Controls.Add(this.DtgPaciente);
            this.Controls.Add(this.ValorLiquiSubsidiadioTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ValorLiContributivoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValorTotalLiquiTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalSubsidiadoTxt);
            this.Controls.Add(this.TotalHombres);
            this.Controls.Add(this.TodosTxt);
            this.Controls.Add(this.Todos);
            this.Controls.Add(this.cmbConsultar);
            this.Controls.Add(this.TotalContributivoTxt);
            this.Controls.Add(this.TotalizarMujeresTxt);
            this.Controls.Add(this.ConsultarBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "ConsultarFrm";
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.DtgPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalSubsidiadoTxt;
        private System.Windows.Forms.Label TotalHombres;
        private System.Windows.Forms.TextBox TodosTxt;
        private System.Windows.Forms.Label Todos;
        private System.Windows.Forms.ComboBox cmbConsultar;
        private System.Windows.Forms.TextBox TotalContributivoTxt;
        private System.Windows.Forms.Label TotalizarMujeresTxt;
        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.TextBox ValorTotalLiquiTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValorLiContributivoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValorLiquiSubsidiadioTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DtgPaciente;
    }
}