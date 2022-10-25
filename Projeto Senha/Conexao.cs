using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Senha
{
    public class Conexao
    {
        public MySqlConnection conecta;

        public void Conectar()
        {
            if (conecta.State == ConnectionState.Closed)
            {
                conecta.ConnectionString = "Server=localhost;Database=bd_senha;User=root;Pwd=cursoads";
                conecta.Open();
            }
        }
        public void Desconectar()
        {
            if(conecta.State == ConnectionState.Open)
            {
                conecta.Close();
            }
        }
        public int ExecSql(String sql)
        {
            int nlinhas;
            try
            {
                MySqlCommand comando = new MySqlCommand(); //instacnia e recebe
                comando.CommandText = sql; //recebe string de conexão
                comando.Connection = conecta; //recebe a parte da conexão (status aberto, fechado)
                nlinhas = comando.ExecuteNonQuery(); //execução comandos que n traz em tabela (select n entra)
            } catch(Exception ex) //trabalha tratamentos = Exception (se der errado no codigo anterior)
            {
                Console.WriteLine("Erro: " + ex);
                nlinhas = 0;
            }
            return nlinhas; //retorna 
        }
    }
}
