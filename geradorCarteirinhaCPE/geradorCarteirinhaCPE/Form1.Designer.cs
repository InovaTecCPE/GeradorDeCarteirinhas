namespace geradorCarteirinhaCPE
{
    partial class frmCarteirinha
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarteirinha));
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.picCarterinha = new System.Windows.Forms.PictureBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnIntervalo = new System.Windows.Forms.Button();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblVal = new System.Windows.Forms.Label();
            this.chkManual = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtManual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateValidade = new System.Windows.Forms.DateTimePicker();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCarterinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(23, 38);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(103, 23);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar Planilha";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(23, 67);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(103, 23);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar Carterinha";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // picCarterinha
            // 
            this.picCarterinha.BackColor = System.Drawing.Color.Transparent;
            this.picCarterinha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCarterinha.Image = ((System.Drawing.Image)(resources.GetObject("picCarterinha.Image")));
            this.picCarterinha.Location = new System.Drawing.Point(149, 13);
            this.picCarterinha.Name = "picCarterinha";
            this.picCarterinha.Size = new System.Drawing.Size(326, 206);
            this.picCarterinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCarterinha.TabIndex = 2;
            this.picCarterinha.TabStop = false;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.White;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(189, 22);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(69, 20);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "ALUNO";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.BackColor = System.Drawing.Color.Transparent;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.Color.White;
            this.lblCod.Location = new System.Drawing.Point(291, 126);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(28, 13);
            this.lblCod.TabIndex = 4;
            this.lblCod.Text = "ID: ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(291, 145);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome: ";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeColumns = false;
            this.dgvDados.AllowUserToResizeRows = false;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 225);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(462, 192);
            this.dgvDados.TabIndex = 6;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.SelectionChanged += new System.EventHandler(this.dgvDados_SelectionChanged);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(23, 126);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(46, 20);
            this.txtMin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Intervalo";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(80, 126);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(46, 20);
            this.txtMax.TabIndex = 10;
            // 
            // btnIntervalo
            // 
            this.btnIntervalo.Location = new System.Drawing.Point(23, 152);
            this.btnIntervalo.Name = "btnIntervalo";
            this.btnIntervalo.Size = new System.Drawing.Size(103, 23);
            this.btnIntervalo.TabIndex = 11;
            this.btnIntervalo.Text = "Gerar Intervalo";
            this.btnIntervalo.UseVisualStyleBackColor = true;
            this.btnIntervalo.Click += new System.EventHandler(this.btnIntervalo_Click);
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal.ForeColor = System.Drawing.Color.Black;
            this.lblVal.Location = new System.Drawing.Point(195, 203);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(237, 12);
            this.lblVal.TabIndex = 12;
            this.lblVal.Text = "Validade: 12/2019                      www.cursinhoeach.com.br";
            // 
            // chkManual
            // 
            this.chkManual.AutoSize = true;
            this.chkManual.Location = new System.Drawing.Point(25, 198);
            this.chkManual.Name = "chkManual";
            this.chkManual.Size = new System.Drawing.Size(101, 17);
            this.chkManual.TabIndex = 13;
            this.chkManual.Text = "Habilitar manual";
            this.chkManual.UseVisualStyleBackColor = true;
            this.chkManual.CheckedChanged += new System.EventHandler(this.chkManual_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Em caso de falha, digite o nome:";
            // 
            // txtManual
            // 
            this.txtManual.Enabled = false;
            this.txtManual.Location = new System.Drawing.Point(197, 423);
            this.txtManual.Name = "txtManual";
            this.txtManual.Size = new System.Drawing.Size(240, 20);
            this.txtManual.TabIndex = 15;
            this.txtManual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtManual_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ano de validade:.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tipo de Carteirinha:.";
            // 
            // dateValidade
            // 
            this.dateValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateValidade.Location = new System.Drawing.Point(29, 88);
            this.dateValidade.Name = "dateValidade";
            this.dateValidade.Size = new System.Drawing.Size(121, 20);
            this.dateValidade.TabIndex = 17;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Aluno",
            "Professor",
            "Plantonista",
            "Membro"});
            this.cmbTipo.Location = new System.Drawing.Point(29, 35);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateValidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Location = new System.Drawing.Point(506, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 165);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(54, 126);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // frmCarteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtManual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkManual);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.btnIntervalo);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.picCarterinha);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnCarregar);
            this.Name = "frmCarteirinha";
            this.Text = "v1.0 - Gerador De Carteirinhas - CPE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCarterinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.PictureBox picCarterinha;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnIntervalo;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.CheckBox chkManual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateValidade;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
    }
}

