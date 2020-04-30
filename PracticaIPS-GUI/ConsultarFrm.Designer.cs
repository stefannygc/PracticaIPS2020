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
            this.label1 = new System.Windows.Forms.Label();
            this.TotalSubsidiadoTxt = new System.Windows.Forms.TextBox();
            this.TotalHombres = new System.Windows.Forms.Label();
            this.TodosTxt = new System.Windows.Forms.TextBox();
            this.Todos = new System.Windows.Forms.Label();
            this.cmbConsultar = new System.Windows.Forms.ComboBox();
            this.TotalContributivoTxt = new System.Windows.Forms.TextBox();
            this.TotalizarMujeresTxt = new System.Windows.Forms.Label();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.DtgPaciente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(296, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tipo De Consulta";
            // 
            // TotalSubsidiadoTxt
            // 
            this.TotalSubsidiadoTxt.Location = new System.Drawing.Point(656, 388);
            this.TotalSubsidiadoTxt.Name = "TotalSubsidiadoTxt";
            this.TotalSubsidiadoTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalSubsidiadoTxt.TabIndex = 29;
            // 
            // TotalHombres
            // 
            this.TotalHombres.AutoSize = true;
            this.TotalHombres.BackColor = System.Drawing.Color.Transparent;
            this.TotalHombres.Location = new System.Drawing.Point(563, 395);
            this.TotalHombres.Name = "TotalHombres";
            this.TotalHombres.Size = new System.Drawing.Size(83, 13);
            this.TotalHombres.TabIndex = 28;
            this.TotalHombres.Text = "TotalSubsidiado";
            // 
            // TodosTxt
            // 
            this.TodosTxt.Location = new System.Drawing.Point(656, 301);
            this.TodosTxt.Name = "TodosTxt";
            this.TodosTxt.Size = new System.Drawing.Size(100, 20);
            this.TodosTxt.TabIndex = 27;
            // 
            // Todos
            // 
            this.Todos.AutoSize = true;
            this.Todos.BackColor = System.Drawing.Color.Transparent;
            this.Todos.Location = new System.Drawing.Point(563, 308);
            this.Todos.Name = "Todos";
            this.Todos.Size = new System.Drawing.Size(37, 13);
            this.Todos.TabIndex = 26;
            this.Todos.Text = "Todos";
            // 
            // cmbConsultar
            // 
            this.cmbConsultar.FormattingEnabled = true;
            this.cmbConsultar.Items.AddRange(new object[] {
            "Todos",
            "Contributivo",
            "Subsidiado"});
            this.cmbConsultar.Location = new System.Drawing.Point(389, 301);
            this.cmbConsultar.Name = "cmbConsultar";
            this.cmbConsultar.Size = new System.Drawing.Size(100, 21);
            this.cmbConsultar.TabIndex = 25;
            // 
            // TotalContributivoTxt
            // 
            this.TotalContributivoTxt.Location = new System.Drawing.Point(656, 345);
            this.TotalContributivoTxt.Name = "TotalContributivoTxt";
            this.TotalContributivoTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalContributivoTxt.TabIndex = 24;
            // 
            // TotalizarMujeresTxt
            // 
            this.TotalizarMujeresTxt.AutoSize = true;
            this.TotalizarMujeresTxt.BackColor = System.Drawing.Color.Transparent;
            this.TotalizarMujeresTxt.Location = new System.Drawing.Point(563, 352);
            this.TotalizarMujeresTxt.Name = "TotalizarMujeresTxt";
            this.TotalizarMujeresTxt.Size = new System.Drawing.Size(87, 13);
            this.TotalizarMujeresTxt.TabIndex = 23;
            this.TotalizarMujeresTxt.Text = "TotalContributivo";
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConsultarBtn.Location = new System.Drawing.Point(343, 345);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(86, 33);
            this.ConsultarBtn.TabIndex = 22;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            this.ConsultarBtn.Click += new System.EventHandler(this.ConsultarBtn_Click);
            // 
            // DtgPaciente
            // 
            this.DtgPaciente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DtgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPaciente.Enabled = false;
            this.DtgPaciente.Location = new System.Drawing.Point(12, 12);
            this.DtgPaciente.Name = "DtgPaciente";
            this.DtgPaciente.Size = new System.Drawing.Size(954, 237);
            this.DtgPaciente.TabIndex = 21;
            // 
            // ConsultarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalSubsidiadoTxt);
            this.Controls.Add(this.TotalHombres);
            this.Controls.Add(this.TodosTxt);
            this.Controls.Add(this.Todos);
            this.Controls.Add(this.cmbConsultar);
            this.Controls.Add(this.TotalContributivoTxt);
            this.Controls.Add(this.TotalizarMujeresTxt);
            this.Controls.Add(this.ConsultarBtn);
            this.Controls.Add(this.DtgPaciente);
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
        private System.Windows.Forms.DataGridView DtgPaciente;
    }
}