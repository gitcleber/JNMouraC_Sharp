using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApp.Repository
{
    public class FuncionarioRepo
    {
        public static List<Models.Funcionario> GetList()//Listar
        {
            List<Models.Funcionario> funcionarios = new List<Models.Funcionario>();

            using (SqlConnection connection = new SqlConnection(Configuration.Parameters.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM Funcionario ORDER BY Codigo;";
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Models.Funcionario funcionario = new Models.Funcionario
                        {
                            Codigo = (int)dataReader["Codigo"],
                            Cod_Depart = (int)dataReader["CodigoDepartamento"],
                            PrimeiroNome = (string)dataReader["PrimeiroNome"],
                            SegundoNome = (string)dataReader["SegundoNome"],
                            UltimoNome = (string)dataReader["UltimoNome"],
                            DtNasc = (DateTime)dataReader["DataNascimento"],
                            CPF = (string)dataReader["CPF"],
                            RG = (string)dataReader["RG"],
                            Endereco = (string)dataReader["Endereco"],
                            CEP = (string)dataReader["CEP"],
                            Cidade = (string)dataReader["Cidade"],
                            Fone = (string)dataReader["Fone"],
                            Funcao = (string)dataReader["Funcao"],
                            Salario = (decimal)dataReader["Salario"]
                        };
                        funcionarios.Add(funcionario);
                    }
                }
            }
            return funcionarios;
        }

        public static void Save(Models.Funcionario funcionario)//Create
        {
            using (SqlConnection connection = new SqlConnection(Configuration.Parameters.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Funcionario (CodigoDepartamento, PrimeiroNome, SegundoNome, UltimoNome, DataNascimento, CPF, RG, Endereco, CEP, Cidade, Fone, Funcao, Salario)" + 
                        " VALUES(@codigo_Depart, @primeiroNome, @segundoNome, @ultimoNome, @dtNasc, @cpf, @rg, @endereco, @cep, @cidade, @fone, @funcao, @salario);";
                    cmd.Parameters.Add(new SqlParameter("@codigo_Depart", System.Data.SqlDbType.Int)).Value = funcionario.Cod_Depart;
                    cmd.Parameters.Add(new SqlParameter("@primeiroNome", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.PrimeiroNome;
                    cmd.Parameters.Add(new SqlParameter("@segundoNome", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.SegundoNome;
                    cmd.Parameters.Add(new SqlParameter("@ultimoNome", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.UltimoNome;
                    cmd.Parameters.Add(new SqlParameter("@dtNasc", System.Data.SqlDbType.DateTime)).Value = funcionario.DtNasc;
                    cmd.Parameters.Add(new SqlParameter("@cpf", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.CPF;
                    cmd.Parameters.Add(new SqlParameter("@rg", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.RG;
                    cmd.Parameters.Add(new SqlParameter("@endereco", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.Endereco;
                    cmd.Parameters.Add(new SqlParameter("@cep", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.CEP;
                    cmd.Parameters.Add(new SqlParameter("@cidade", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.Cidade;
                    cmd.Parameters.Add(new SqlParameter("@fone", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.Fone;
                    cmd.Parameters.Add(new SqlParameter("@funcao", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.Funcao;
                    cmd.Parameters.Add(new SqlParameter("@salario", System.Data.SqlDbType.Decimal)).Value = funcionario.Salario;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Models.Funcionario GetFuncionario(int codigo)//Read
        {
            //("SELECT * FROM TABLE WHERE ID = " + id)

            Models.Funcionario funcionario = new Models.Funcionario();// Cria o Objeto para receber os dados do banco relativo ao id buscado para retornar á View Details;

            using (SqlConnection connection = new SqlConnection(Configuration.Parameters.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM Funcionario WHERE Codigo = @codigo;";
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = codigo;
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    //while(datareader.Read())//percorre as linhas do datareader até atingir o fim EOF=end of file;
                    if (dataReader.Read()) //Posiciona o Leitor na primeira linha, e se true entra no if ne false pula
                    {
                        funcionario.Codigo = (int)dataReader["Codigo"];
                        funcionario.Cod_Depart = (int)dataReader["CodigoDepartamento"];
                        funcionario.PrimeiroNome = (string)dataReader["PrimeiroNome"];
                        funcionario.SegundoNome = (string)dataReader["SegundoNome"];
                        funcionario.UltimoNome = (string)dataReader["UltimoNome"];
                        funcionario.DtNasc = (DateTime)dataReader["DataNascimento"];
                        funcionario.CPF = (string)dataReader["CPF"];
                        funcionario.RG = (string)dataReader["RG"];
                        funcionario.Endereco = (string)dataReader["Cidade"];
                        funcionario.Fone = (string)dataReader["Fone"];
                        funcionario.Funcao = (string)dataReader["Funcao"];
                        funcionario.Salario = (decimal)dataReader["Salario"];
                    }
                    return funcionario;
                }
            }
        }

        public static void Update(Models.Funcionario funcionario)//Update
        {
            using (SqlConnection connection = new SqlConnection(Configuration.Parameters.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE Funcionario SET CodigoDepartamento = @Cod_Depart, PrimeiroNome = @PrimeiroNome, SegundoNome = @SegundoNome, UltimoNome = @UltimoNome, DataNascimento = @DtNasc, CPF = @CPF, RG = @RG, Endereco = @Endereco, CEP = CEP, Cidade = @Cidade, Fone = @Fone, Funcao = @Funcao, Salario = @Salario" +
                        " WHERE Codigo = @codigo;";
                    cmd.Parameters.Add(new SqlParameter("@Cod_Depart", System.Data.SqlDbType.Int)).Value = funcionario.Cod_Depart;
                    cmd.Parameters.Add(new SqlParameter("@PrimeiroNome", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.PrimeiroNome;
                    cmd.Parameters.Add(new SqlParameter("@SegundoNome", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.SegundoNome;
                    cmd.Parameters.Add(new SqlParameter("@UltimoNome", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.UltimoNome;
                    cmd.Parameters.Add(new SqlParameter("@DataNascimento", System.Data.SqlDbType.DateTime)).Value = funcionario.DtNasc;
                    cmd.Parameters.Add(new SqlParameter("@CPF", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.CPF;
                    cmd.Parameters.Add(new SqlParameter("@RG", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.RG;
                    cmd.Parameters.Add(new SqlParameter("@Endereco", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.Endereco;
                    cmd.Parameters.Add(new SqlParameter("@CEP", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.CEP;
                    cmd.Parameters.Add(new SqlParameter("@Cidade", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.Cidade;
                    cmd.Parameters.Add(new SqlParameter("@Fone", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.Fone;
                    cmd.Parameters.Add(new SqlParameter("@Funcao", System.Data.SqlDbType.VarChar, 255)).Value = funcionario.Funcao;
                    cmd.Parameters.Add(new SqlParameter("@Salario", System.Data.SqlDbType.Decimal)).Value = funcionario.Salario;
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = funcionario.Codigo;
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
                    cmd.CommandText = "DELETE FROM Funcionario WHERE codigo = @codigo";
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = codigo;
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}