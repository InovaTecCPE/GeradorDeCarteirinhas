using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;
//using Windows.UI.ViewManagement;

namespace geradorCarteirinhaCPE
{
    public partial class frmCarteirinha : Form
    {
        public frmCarteirinha()
        {
            InitializeComponent();
        }

        int tipo = 0;
        /* 0 Aluno
         * 1 Professor
         * 2 Platonista
         * 3 Membro
         */

        private void Form1_Load(object sender, EventArgs e)
        {
            //Fundo das Labels para transparente
            var pos = this.PointToScreen(lblCargo.Location);
            pos = picCarterinha.PointToClient(pos);
            lblCargo.Parent = picCarterinha;
            lblCargo.Location = pos;
            lblCargo.BackColor = Color.Transparent;

            pos = this.PointToScreen(lblNome.Location);
            pos = picCarterinha.PointToClient(pos);
            lblNome.Parent = picCarterinha;
            lblNome.Location = pos;
            lblNome.BackColor = Color.Transparent;

            pos = this.PointToScreen(lblCod.Location);
            pos = picCarterinha.PointToClient(pos);
            lblCod.Parent = picCarterinha;
            lblCod.Location = pos;
            lblCod.BackColor = Color.Transparent;

            pos = this.PointToScreen(lblVal.Location);
            pos = picCarterinha.PointToClient(pos);
            lblVal.Parent = picCarterinha;
            lblVal.Location = pos;
            lblVal.BackColor = Color.Transparent;

            //MessageBox.Show(lblNome.Top.ToString());
        }

        public void CarregaClasse()
        {
            clnConfig cln = new clnConfig();
            MessageBox.Show(cln.Ano_validade.ToString());
            lblVal.Text = "Validade: 12/" + cln.Ano_validade + "                      www.cursinhoeach.com.br";
            //lblCargo.Text = cln.Cargo.ToUpper();

            //Centralizando Cargo em relação a Foto
            //int meio = picCarterinha.Width / 2 + picCarterinha.Location.X;
            //lblCargo.Left = meio;
            //lblCargo.Left = lblCargo.Left - meio;
        }
            

        string excelAddress = @"DadosAlunos.xlsx";

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult drResult = ofd1.ShowDialog();
                if (drResult == System.Windows.Forms.DialogResult.OK)
                    excelAddress = ofd1.FileName;
                else
                    return;

                CarregaDados();

                if (dgvDados.RowCount != 0)
                {
                    txtMin.Text = 1.ToString();
                    txtMax.Text = dgvDados.RowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void CarregaDados()
        {
            DataTable dt = GetTabelaExcel(excelAddress);
            dgvDados.DataSource = dt;
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        DataTable GetTabelaExcel(string arquivo)
        {
            DataTable dt = new DataTable();

            try
            {
                //pega a extensão do arquivo
                string Ext = Path.GetExtension(arquivo);
                string connectionString = "";
                //verifica a versão do Excel pela extensão
                if (Ext == ".xlsx")
                { //para o  Excel 07 e superior
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + arquivo + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }


                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                cmd.Connection = conn;
                conn.Open();

                DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomePlanilha = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();

                //le todos os dados da planilha para o Data Table    
                conn.Open();
                cmd.CommandText = "SELECT * From [" + nomePlanilha + "]";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;

        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (tipo)
            {
                case 0:
                    int id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value);
                    CarregaCellCarteirinhaAluno(id, 0);
                    break;

                case 1:
                    CarregaCellCarteirinhaProfessor(0);
                    break;
            }
        }

        private void dgvDados_SelectionChanged(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case 0:
                    int id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value);
                    CarregaCellCarteirinhaAluno(id, 0);
                    break;

                case 1:
                    CarregaCellCarteirinhaProfessor(0);
                    break;
            }
        }

        //Guardar caminho do file dialog
        string caminho = "";

        //Botão Gera 1
        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDados.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecione uma linha");
                    return;
                }

                //Iniciando um file dialog
                DialogResult drResult = fbd1.ShowDialog();
                if (drResult == System.Windows.Forms.DialogResult.OK)
                    caminho = fbd1.SelectedPath;

                if (caminho == "") return;

                string id = dgvDados.CurrentRow.Cells[0].Value.ToString();

                switch (tipo)
                {
                    case 0:
                        CarregaCellCarteirinhaAluno(Convert.ToInt32(id), 0);
                        break;
                    case 1:
                        CarregaCellCarteirinhaProfessor(0);
                        break;
                }
                
                GeraCarterinha(id);

                MessageBox.Show("Carteirinha do Aluno " + dgvDados.CurrentRow.Cells[1].Value.ToString() + " gerada e salva");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        
        //Botão Gera N
        private async void btnIntervalo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDados.Rows.Count == 0)
                {
                    MessageBox.Show("Por favor, carregue os dados");
                    return;
                }
                if (txtMin.Text == "" || txtMax.Text == "")
                {
                    MessageBox.Show("Por favor, preecha os intervalos");
                    return;
                }

                //Validação
                int linhas = Convert.ToInt32(dgvDados.RowCount);
                int min = Convert.ToInt32(txtMin.Text);
                int max = Convert.ToInt32(txtMax.Text);
                if (min < 1 || max > linhas)
                {
                    MessageBox.Show("Intervalo invalido, por favor verifique");
                    return;
                }

                DialogResult drResult = fbd1.ShowDialog();
                if (drResult == System.Windows.Forms.DialogResult.OK)
                    caminho = fbd1.SelectedPath;

                if (caminho == "") return;

                for (int i = (min - 1); i <= (max - 1); i++) //Reduzindo 1 pq o index começa em 0
                {
                    string id = dgvDados.Rows[i].Cells[0].Value.ToString();
                    switch (tipo)
                    {
                        case 0:

                            CarregaCellCarteirinhaAluno(Convert.ToInt32(id), i); //Carregando na picturebox
                            break;

                        case 1:
                            CarregaCellCarteirinhaProfessor(i);
                            break;
                    }
                    await Task.Delay(300); //Delay de meio segundo
                    GeraCarterinha(id); //Printando a picturebox
                }

                MessageBox.Show("Carterinhas geradas e salvas");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        //Metodo pra gerar uma carteirinha
        private void GeraCarterinha(string id)
        {
            //Bitmap do tamanho da picture box
            Bitmap carteirinhaImg = new Bitmap(picCarterinha.Size.Width,picCarterinha.Size.Height, PixelFormat.Format32bppArgb);
            Graphics carteirinha = Graphics.FromImage(carteirinhaImg);

            //Salvando posição NA TELA da picture box
            var pos = this.PointToScreen(picCarterinha.Location);

            //Copiando carteirinha na tela e salvando como imagem
            carteirinha.CopyFromScreen(pos.X, pos.Y, 0, 0, carteirinhaImg.Size);
            string[] nomex = lblNome.Text.Split(' ');
            carteirinhaImg.Save(fbd1.SelectedPath + "\\" + id + " - " + nomex[1] + ".jpg", ImageFormat.Jpeg);
        }

        private void CarregaCellCarteirinhaAluno(int id, int linha)
        {
            try
            {
                lblCod.Text = "ID: ";
                lblNome.Text = "Nome: ";
                lblCod.Text += id.ToString();
                string nome = "";
                if (linha == 0)
                    nome = dgvDados.CurrentRow.Cells[1].Value.ToString();
                else
                    nome = dgvDados.Rows[linha].Cells[1].Value.ToString();

                string[] nomex = nome.Split(' ');

                //Algo pra quebrar linha

                if (nome.Length < 18)
                    lblNome.Text += nome;
                else
                {
                    bool puloulinha = false;
                    int max = 180;
                    for (int i = 0; i < nomex.Length; i++)
                    {
                        if (puloulinha)
                        {
                            max = lblNome.Width;
                            puloulinha = false;
                        }

                        string antigo = lblNome.Text;
                        lblNome.Text += nomex[i];
                        if (lblNome.Width > max )
                        {
                            lblNome.Text = antigo;
                            lblNome.Text += " \n";
                            lblNome.Text += nomex[i];
                            puloulinha = true;
                        }
                        lblNome.Text += ' ';
                    }
                    //MessageBox.Show(lblNome.Width.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
        private void CarregaCellCarteirinhaProfessor(int linha)
        {
            try
            {
                lblCod.Text = "Nome: ";
                lblNome.Text = "Disciplina: ";
                lblNome.Top = 131;
                lblNome.Text += dgvDados.Rows[linha].Cells[1].Value.ToString();
                string nome = "";
                if (linha == 0)
                    nome = dgvDados.CurrentRow.Cells[0].Value.ToString();
                else
                    nome = dgvDados.Rows[linha].Cells[0].Value.ToString();

                string[] nomex = nome.Split(' ');

                //Algo pra quebrar linha

                if (nome.Length < 18)
                    lblCod.Text += nome;
                else
                {
                    bool puloulinha = false;
                    int max = 180;
                    for (int i = 0; i < nomex.Length; i++)
                    {
                        if (puloulinha)
                        {
                            max = lblCod.Width;
                            puloulinha = false;
                            //lblNome.Top += lblCod.Height;
                        }

                        string antigo = lblCod.Text;
                        lblCod.Text += nomex[i];
                        if (lblCod.Width > max)
                        {
                            lblCod.Text = antigo;
                            lblCod.Text += " \n";
                            lblCod.Text += nomex[i];
                            puloulinha = true;
                        }
                        lblCod.Text += ' ';
                    }
                    lblNome.Top = 131 + lblCod.Height;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void chkManual_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManual.Checked == true && dgvDados.RowCount != 0 && lblNome.Text.Equals("Nome: "))
                txtManual.Enabled = true;
            else
                txtManual.Enabled = false;
        }

        private void txtManual_KeyDown(object sender, KeyEventArgs e)
        {
            string nome = "";
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                nome = txtManual.Text;
            else
                return;

            
            char[] nomex = nome.ToCharArray();

            //Algo pra quebrar linha

            if (nome.Length > 18)
            {
                for (int i = 0; i < nomex.Length; i++)
                {
                    if (i == 20)
                    {
                        if (nomex[i] == ' ')
                            lblNome.Text += "\n";
                        else
                        {
                            lblNome.Text += "-\n";
                        }
                    }
                    lblNome.Text += nomex[i];
                }
            }
            else
                lblNome.Text += nome;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //Atualizando data
            lblVal.Text = "Validade: 12/" + dateValidade.Value.Year + "                      www.cursinhoeach.com.br";


            //Atualizando label e centralizando em relação a Foto
            lblCargo.Text = cmbTipo.SelectedItem.ToString().ToUpper();

            //int meio = picCarterinha.Width / 2 + picCarterinha.Location.X;
            //lblCargo.Left = meio;
            //lblCargo.Left = lblCargo.Left - (lblCargo.Left - pictureBox1.Location.X);

            //Atualizando Tipo de Geração
            tipo = cmbTipo.Items.IndexOf(cmbTipo.SelectedItem.ToString());
        }
    }
}
