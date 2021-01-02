using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valter.Gomes
{
    public partial class Form1 : Form
    {
        private Valter.DAO.Voo _voo = new DAO.Voo();
        private Valter.DAL.Data.Voo _Dal = new Valter.DAL.Data.Voo();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Limpar os Campos.
            LimparCampos();

            // Método para verificar e criar a base de dado
            //Valter.DAL.Base.CreateDataBase.CreateDbase();
            // Método para carregar a lista de voo no grid
            CarregaListaDeVoo();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampo())
            {
                RecuperaValorCampo();

                if (_voo.ID_VOO > 0)
                {
                    // alterar
                    if (_Dal.Altera(_voo))
                    {
                        Mensagem("Voo alterado com sucesso!", MessageBoxButtons.OK); LimparCampos();
                    }
                    else
                    {
                        Mensagem("Voo não alterado, favor verifique os dados!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    //Cadastra
                    if (_Dal.Cadastra(_voo))
                    {
                        Mensagem("Voo cadastrado com sucesso!", MessageBoxButtons.OK); LimparCampos();
                    }
                    else
                    {
                        Mensagem("Voo não cadastrado,favor verifique os dados!", MessageBoxButtons.OK);
                    }
                }

                CarregaListaDeVoo();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            //Carrega todos os voos cadastrados no grid.
            CarregaListaDeVoo();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            RecuperaValorCampo();

            if (_voo.ID_VOO > 0)
            {
                RecuperaValorCampo();
                // Excluir
                if (_Dal.Deleta(_voo))
                {
                    Mensagem("Voo Excluido com sucesso!", MessageBoxButtons.OK); LimparCampos();
                }
                else
                {
                    Mensagem("Voo não Excluido,favor verifique os dados!", MessageBoxButtons.OK);
                }
                CarregaListaDeVoo();
            }
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnSalvar.Enabled = !string.IsNullOrWhiteSpace(txtData.Text) ? true : false;
            btnCancelar.Enabled = !string.IsNullOrWhiteSpace(txtData.Text) ? true : false;
        }

        private void txtData_KeyUp(object sender, KeyEventArgs e)
        {
            btnSalvar.Enabled = !string.IsNullOrWhiteSpace(txtData.Text) ? true : false;
            btnCancelar.Enabled = !string.IsNullOrWhiteSpace(txtData.Text) ? true : false;
        }

        //limpa os campos toda vez que é reniciado
        private void LimparCampos()
        {
            txtData.Text = "";
            txtCusto.Text = "";
            txtDistancia.Text = "";
            txtID.Text = "";
            txtNivelDor.Text = "";
            rdButtonSim.Checked = false;
            rdButtonNao.Checked = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        //Valida os campos caso usuário nao preencha
        private bool ValidaCampo()
        {
            if (string.IsNullOrEmpty(txtData.Text))
            {
                Mensagem("Favor informe o data", MessageBoxButtons.OK); return false;
            }

            if (string.IsNullOrEmpty(txtCusto.Text))
            {
                Mensagem("Favor informe o custo", MessageBoxButtons.OK); return false;
            }

            if (string.IsNullOrEmpty(txtDistancia.Text))
            {
                Mensagem("Favor informe a distância", MessageBoxButtons.OK); return false;
            }

            if (rdButtonSim.Checked == false && rdButtonNao.Checked == false)
            {
                Mensagem("Informe a opção da Captura", MessageBoxButtons.OK); return false;
            }

            if (string.IsNullOrEmpty(txtNivelDor.Text))
            {

                Mensagem("Favor informe o nível da dor", MessageBoxButtons.OK); return false;
            }

            if (Convert.ToInt32(txtNivelDor.Text) > 10)
            {
                Mensagem("Informe o 'Nivel de dor' de 0 a 10!", MessageBoxButtons.OK);
            }

            return true;
        }

        private void Mensagem(string text, MessageBoxButtons tipoButton)
        {
            MessageBox.Show(text, "Mensagem", tipoButton);
        }

        private void RecuperaValorCampo()
        {
            _voo.DATA_VOO = Convert.ToDateTime(txtData.Text);
            _voo.CUSTO = Convert.ToDouble(txtCusto.Text);
            _voo.DISTANCIA = Convert.ToInt32(txtDistancia.Text);
            _voo.ID_VOO = (string.IsNullOrEmpty(txtID.Text) ? 0 : Convert.ToInt32(txtID.Text));
            _voo.NIVEL_DOR = Convert.ToInt32(txtNivelDor.Text);
            _voo.CAPTURA = Convert.ToChar(rdButtonSim.Checked == true ? "S" : "N");
        }

        private void CarregaListaDeVoo()
        {
            // Carrega no grid os voos
            drGridViemVoo.DataSource = null;
            drGridViemVoo.Rows.Clear();

            foreach (var voo in _Dal.ListaTodos())
            {
                drGridViemVoo.Rows.Add(voo.ID_VOO, voo.DATA_VOO.ToString("dd/MM/yyyy"), voo.CAPTURA.ToString(), voo.NIVEL_DOR, voo.CUSTO, voo.DISTANCIA);
            }
        }

        private void drGridViemVoo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Ao clicar nas linhas da célula do DataGridView estes códigos colocam as informações em TextBoxs */
            txtID.Text = drGridViemVoo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtData.Text = drGridViemVoo.Rows[e.RowIndex].Cells[1].Value.ToString();
            rdButtonSim.Checked = (drGridViemVoo.Rows[e.RowIndex].Cells[2].Value.ToString() == "S" ? true : false);
            rdButtonNao.Checked = (drGridViemVoo.Rows[e.RowIndex].Cells[2].Value.ToString() == "N" ? true : false);
            txtNivelDor.Text = drGridViemVoo.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCusto.Text = drGridViemVoo.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDistancia.Text = drGridViemVoo.Rows[e.RowIndex].Cells[5].Value.ToString();

            btnSalvar.Enabled = !string.IsNullOrWhiteSpace(txtData.Text) ? true : false;
            btnCancelar.Enabled = !string.IsNullOrWhiteSpace(txtData.Text) ? true : false;
        }

        //Validação de 0 a 10 do campo nivel dor

        private void txtNivelDor_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsDigit(Convert.ToChar(e.KeyValue)) && !char.IsControl(Convert.ToChar(e.KeyValue)) && !char.IsLetter(Convert.ToChar(e.KeyValue)))
            {
                if (Convert.ToInt32(txtNivelDor.Text) > 10)
                {
                    e.Handled = true;
                    Mensagem("Informe o 'Nivel de dor' de 0 a 10!", MessageBoxButtons.OK);
                }
            }
        }
        //validaçao de caracters
        private void txtNivelDor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
                Mensagem("Informe o 'Nivel de dor' de 0 a 10!", MessageBoxButtons.OK);
            }
        }
    }
}
