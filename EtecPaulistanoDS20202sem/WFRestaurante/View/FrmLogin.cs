using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WFRestaurante.Properties;

namespace WFRestaurante
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {



            
            SqlConnection sqlConnection;
            DataTable dataTable = new DataTable();
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Settings.Default.stringConnection;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandTimeout = 1800;
            sqlCommand.CommandText = "select ID, LOGIN FROM USUARIO where LOGIN = '"+textBoxLogin.Text+"' AND PWDCOMPARE('"+textBoxSenha.Text+"',senha)=1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable); // .Fill() Esse método busca no Banco as informações e adapta dentro do DataTable
            if (dataTable.Rows.Count == 1)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.Login = (String) item["Login"]; // CAST
                    
                    Settings.Default.autenticado = true;
                    this.Close();

                    return;

                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido");
             
                
            }

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
    }
}
