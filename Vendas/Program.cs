using System;

namespace Vendas
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao = "";

            while (opcao != "0") {

                Console.WriteLine("DIGITE A OPÇÃO DESEJADA\n");


                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Cadastrar vendedor");
                Console.WriteLine("2. Consultar vendedor");
                Console.WriteLine("3. Excluir vendedor");
                Console.WriteLine("4. Registrar Venda");
                Console.WriteLine("5. listar Vendedores");

                opcao = Console.ReadLine();



                switch ((opcao)
)
                {

                    case "1":
                        {


                            Vendedores vendedor = new Vendedores(10);






                            break;
                            }

                    default:
                        break;
                }




            }



        }
    }
}
