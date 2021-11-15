using System;

namespace PrefeituraSenso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Criar um programa para o censo de uma prefeitura
              Receber o salário e numero de filhos da familia
              Imprimir:
                    média do salário da população,
                    média de filhos,
                    maior salário,
                    percentual dos que ganham abaixo de 150,00;
              
              */
            const double salario150 = 150;
            double salario = 0.0, totalSalario = 0, mediaSalarios, maiorSalario = 0;
            double percPessoasSalMenor150, mediaNumFilhos;
            bool valido;
            int qtdeFilhos = 0, totalFilhos = 0, qtdePessoas = 0;
            int qtdePessoasSalMenor150 = 0;

            do
            {
                Console.Write("Qual o salario: ");
                valido = double.TryParse(Console.ReadLine(), out salario);//tryParse não deixa o programa crashar caso digitar valores diferente de numeros.
                if (valido)
                {
                    if (salario >= 0)
                    {
                        bool continuar = true;
                        do
                        {
                            Console.Write("Quantos filhos: ");
                            valido = int.TryParse(Console.ReadLine(), out qtdeFilhos);
                            if ((valido) && (qtdeFilhos >= 0))
                            {
                                if (salario > maiorSalario)
                                    maiorSalario = salario;
                                if (salario <= salario150)
                                    qtdePessoasSalMenor150++;

                                totalSalario += salario;
                                totalFilhos += qtdeFilhos;
                                qtdePessoas++;
                                continuar = false;
                            }
                            else
                            {
                                Console.WriteLine("Entrada Inválida");
                            }
                        } while (continuar);
                    }
                }
                else
                {
                    Console.WriteLine("Entrada Inválida");
                }
            } while (salario >= 0);

            if (qtdePessoas > 0)
            {
                mediaSalarios = totalSalario / qtdePessoas;
                mediaNumFilhos = (double)totalFilhos / qtdePessoas;
                percPessoasSalMenor150 = qtdePessoasSalMenor150 / (double)qtdePessoas * 100;
                
                Console.WriteLine("Média de salário da população: ${0:0.00}",mediaSalarios);
                Console.WriteLine("Média de número de filhos: {0:0.0}",mediaNumFilhos);
                Console.WriteLine("Maior Salario: ${0}",maiorSalario);
                Console.WriteLine("Percentual de pessoas com salário até 150,00: {0:00.0}%",percPessoasSalMenor150);

            }
            else
            {
                Console.WriteLine("Sem dados para gerar relatório...");
            }

            Console.ReadLine();
        }
    }
}
