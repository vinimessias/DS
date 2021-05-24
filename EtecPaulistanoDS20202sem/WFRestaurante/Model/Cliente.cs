using System;
using System.Data;
using System.Data.SqlClient;
using WFRestaurante.Control;
using WFRestaurante.Model;

namespace WFRestaurante
{
    public class Cliente : Pessoa
    {
        public int Id { get; set; }
        public String Telefone { get; set; }

        public void Adicionar(Cliente cliente)
        {
            try
            {
                this.Persistencia(cliente, "uspPessoasAdd");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public void Atualizar(Cliente cliente)
        {
            try
            {  
                this.Persistencia(cliente, "uspPessoasUpd");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Persistencia(Cliente cliente, String comando)
        {
            try
            {
                SqlServer sqlServer = new SqlServer();
               
                SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
                sqlParameterCollection.Add(new SqlParameter("@ID", cliente.Id));
                sqlParameterCollection.Add(new SqlParameter("@NOME", cliente.Nome));
                sqlParameterCollection.Add(new SqlParameter("@DATANASCIMENTO", cliente.Nascimento));

                 sqlServer.Executar(comando, sqlParameterCollection);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Cancelar(Cliente cliente)
        { 
        
        }
        public Clientes Consultar(String pesquisa)
        {
            Clientes clientes = new Clientes();
            try
            {         
                SqlServer sqlServer = new SqlServer();
                String comando = "";
                comando = "uspPessoasConsultar";
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@pesquisa";
                sqlParameter.Value = pesquisa;
                DataTable dataTable = sqlServer.Consultar(comando,CommandType.StoredProcedure, sqlParameter);
                foreach (DataRow linha in dataTable.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = (Int32) linha["ID"];
                    cliente.Nome = linha["NOME"].ToString();
                    cliente.Nascimento = Convert.ToDateTime(linha["DATANASCIMENTO"]);
                    clientes.Add(cliente);
                }

                return clientes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

    }
}
