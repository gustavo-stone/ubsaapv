using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source=us-cdbr-east-05.cleardb.net; Initial Catalog=heroku_167708e770231d5; User Id=b21b64ebf7714d; Password=f299e371;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            string SQL = "SELECT nome FROM tb_admin";
            cmd.CommandText = SQL;
            try
            {
                conexao.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader result = cmd.ExecuteReader();
                lblTeste.Text = result.GetString(0);
                lblTeste.BackColor = Color.Green;
            }
            catch(Exception err)
            {
                lblTeste.Text = err.Message;
                lblTeste.BackColor = Color.Red;
            }
        }
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string num_cns = txtCns.Text;
            int id_permissao = 0;
            try{
                SqlConnection conexao = new SqlConnection("Data Source=us-cdbr-east-05.cleardb.net; Initial Catalog=heroku_167708e770231d5; User Id=b21b64ebf7714d; Password=f299e371;");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                string SQL = "INSERT INTO tb_paciente (ID_paciente,nome,cpf,email, senha,num_cns,id_permissao) VALUES (@ID_paciente,@nome,@cpf,@email,@senha,@num_cns,@id_permissao)";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("ID_paciente", id);
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("cpf", cpf);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("senha", senha);
                cmd.Parameters.AddWithValue("num_cns", num_cns);
                cmd.Parameters.AddWithValue("ID_permissao", id_permissao);
                cmd.ExecuteNonQuery();
                id += 1;
                lblTeste.Text = "deu certo";
                lblTeste.BackColor = Color.Green;
            }catch(Exception err)
            {
                lblTeste.Text = err.Message;
                lblTeste.BackColor = Color.Red;
            }
        }
    }
}
