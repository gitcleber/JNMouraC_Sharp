using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApp.Repository
{
    public class DepartamentoRepo
    {
        public static List<Models.Departamento> GetList()//Listar
        {
            List<Models.Departamento> departamentos = new List<Models.Departamento>();

            using (SqlConnection connection = new SqlConnection(Configuration.Parameters.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM Departamento ORDER BY Codigo;";
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Models.Departamento departamento = new Models.Departamento
                        {
                            Codigo = (int)dataReader["Codigo"],
                            Nome = (string)dataReader["Nome"]
                        };
                        departamentos.Add(departamento);
                    }
                }
            }
            return departamentos;
        }

        public static void Save(Models.Departamento departamento)//Create
        {
            using (SqlConnection connection = new SqlConnection(Configuration.Parameters.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Departamento (Nome) VALUES(@nome);";
                    cmd.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar, 255)).Value = departamento.Nome;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Models.Departamento Get(int codigo)//Read
        {
            //("SELECT * FROM TABLE WHERE ID = " + id)

            Models.Departamento departamento = new Models.Departamento();// Cria o Objeto para receber os dados do banco relativo ao id buscado para retornar á View Details;

            using (SqlConnection connection = new SqlConnection(Configuration.Parameters.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT Codigo, Nome FROM Departamento WHERE Codigo = @codigo;";
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = codigo;
                    SqlDataReader datareader = cmd.ExecuteReader();

                    //while(datareader.Read())//percorre as linhas do datareader até atingir o fim EOF=end of file;
                    if (datareader.Read()) //Posiciona o Leitor na primeira linha, e se true entra no if ne false pula
                    {
                        departamento.Codigo = (int)datareader["Codigo"];
                        departamento.Nome = (string)datareader["Nome"];
                    }
                    return departamento;
                }
            }
        }

        public static void Update(Models.Departamento departamento)//Update
        {
            using (SqlConnection connection = new SqlConnection(Configuration.Parameters.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE Departamento SET Nome = @nome WHERE Codigo=@codigo;";
                    cmd.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar, 255)).Value = departamento.Nome;
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = departamento.Codigo;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int codigo)//Delete
        {
            using (SqlConnection connection = new SqlConnection(Configuration.Parameters.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM Departamento WHERE codigo = @codigo";
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = codigo;
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}