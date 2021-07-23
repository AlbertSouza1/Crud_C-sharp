using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Loja.DTO;
using Loja.BLL;

namespace Loja
{
    public partial class Cadastro_usuario : Form
    {
        string modo = "";
        public Cadastro_usuario()
        {
            InitializeComponent();
        }

        private void Cadastro_usuario_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
        private void carregarGrid()
        {
            try
            {
                IList<usuario_DTO> listUsuario_DTO = new List<usuario_DTO>();
                listUsuario_DTO = new UsuarioBLL().cargaUsuario();

                dataGridView1.DataSource = listUsuario_DTO;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas ao mostrar usuários");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            modo = "select";

            int sel = dataGridView1.CurrentRow.Index;

            txtCodigo.Text = Convert.ToString(dataGridView1["cod_usuario", sel].Value);
            txtNome.Text = Convert.ToString(dataGridView1["nome", sel].Value);
            txtLogin.Text = Convert.ToString(dataGridView1["login", sel].Value);
            txtEmail.Text = Convert.ToString(dataGridView1["email", sel].Value);
            txtSenha.Text = Convert.ToString(dataGridView1["senha", sel].Value);
            txtCadastro.Text = Convert.ToString(dataGridView1["cadastro", sel].Value);
            
            if(Convert.ToString(dataGridView1["situacao", sel].Value) == "A")
            {
                cboSituacao.Text = "Ativo";
            } else
            {
                cboSituacao.Text = "Inativo";
            }
            
            if(Convert.ToInt32(dataGridView1["perfil", sel].Value) == 1)
            {
                cboPerfil.Text = "Administrador";
            } 
            else if(Convert.ToInt32(dataGridView1["perfil", sel].Value) == 2)
            {
                cboPerfil.Text = "Operador";
            }
            else
            {
                cboPerfil.Text = "Gerencial";
            }
             
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();

            txtCadastro.Text = Convert.ToString(System.DateTime.Now);

            modo = "novo";
        }
        public void limparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtLogin.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtCadastro.Text = "";
            cboPerfil.Text = "";
            cboSituacao.Text = "";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (modo == "novo")
            {
                usuario_DTO usuario = new usuario_DTO();
               
                usuario.nome = txtNome.Text;
                usuario.login = txtLogin.Text;
                usuario.email = txtEmail.Text;
                usuario.senha = txtSenha.Text;
                usuario.cadastro = Convert.ToDateTime(txtCadastro.Text);
                usuario.situacao = cboSituacao.Text;

                switch(cboPerfil.Text)
                {
                    case "Administrador":
                        usuario.perfil = 1;
                        break;
                    case "Operador":
                        usuario.perfil = 2;
                        break;
                    case "Gerencial":
                        usuario.perfil = 3;
                        break;
                }
                    

                

                try
                {
                    bool retorno = new UsuarioBLL().inserirUsuario(usuario);

                    if (retorno)
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carregarGrid();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ops, temos um problema: " + ex.Message);   
                }
            }
            else if(modo == "alterar")
            {
                usuario_DTO usuario = new usuario_DTO();

                usuario.cod_usuario = Convert.ToInt32(txtCodigo.Text);
                usuario.nome = txtNome.Text;
                usuario.login = txtLogin.Text;
                usuario.email = txtEmail.Text;
                usuario.senha = txtSenha.Text;
                usuario.cadastro = Convert.ToDateTime(txtCadastro.Text);
                usuario.situacao = cboSituacao.Text;

                switch (cboPerfil.Text)
                {
                    case "Administrador":
                        usuario.perfil = 1;
                        break;
                    case "Operador":
                        usuario.perfil = 2;
                        break;
                    case "Gerencial":
                        usuario.perfil = 3;
                        break;
                }

                try
                {
                    bool retorno = new UsuarioBLL().alterarUsuario(usuario);

                    if (retorno)
                        MessageBox.Show("Usuário alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carregarGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ops, temos um problema: " + ex.Message);
                }
            } else if(modo == "excluir")
            {
                int cod_usuario = Convert.ToInt32(txtCodigo.Text);
                try
                {
                    bool retorno = new UsuarioBLL().excluirUsuario(cod_usuario);

                    if (retorno)
                        MessageBox.Show("Usuário excluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carregarGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ops, temos um problema: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma ação nos botões do menu!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Selecione um usuário para alterar!");
            }
            else
            {
                modo = "alterar";
            }
            

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Selecione um usuário para deletar!");
            }
            else
            {
                modo = "excluir";
            }
        }
    }
}
