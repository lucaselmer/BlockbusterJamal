using System;
using View;

namespace BlockbusterJamal
{
    public class Principal{
         public static void Main(String[] args){
            int menu = 0;
            do{
            Console.WriteLine("|#################################|");
            Console.WriteLine("|_______ BlockBuster Jamal _______|");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("|_________  Cadastros  ___________|");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("|   (1)  Cadastrar Cliente        |");
            Console.WriteLine("|   (2)  Cadastrar Filme          |");
            Console.WriteLine("|   (3)  Cadastrar Locação        |");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("|_________  Consultas  ___________|");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("|   (4)  Consultar Cliente        |");
            Console.WriteLine("|   (5)  Consultar Filme          |");
            Console.WriteLine("|   (6)  Consultar Locação        |");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("|_______ Listas Completa _________|");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("|   (7)  Lista de Cliente         |");
            Console.WriteLine("|   (8)  Lista de Filme           |");
            Console.WriteLine("|   (9)  Lista de Locação         |");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("|   (0)         Sair              |");
            Console.WriteLine("|#################################|");

            Console.WriteLine("\nInforme uma Opção: ");
                try{
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                catch{
                    Console.WriteLine("** Opção escolhida não é valida **");
                    menu = 10;
                }
                switch (menu)
                {
                    case 1: // Cadastrar
                        ClienteView.CadastrarCliente();
                        break;
                    case 2: 
                        FilmeView.CadastrarFilme();
                        break;
                    case 3: 
                        LocacaoView.CadastrarLocacao();
                        break;
                    case 4: // Consultas
                        ClienteView.ConsultarCliente();
                        break;
                    case 5: 
                        FilmeView.ConsultarFilme();
                        break;
                    case 6:
                        LocacaoView.ConsultarLocacao();
                        break;
                    case 7: // Listas
                        ClienteView.ListarClientes(); 
                        break;
                    case 8:
                        FilmeView.ListarFilmes();
                        break;
                    case 9:
                        LocacaoView.ListarLocacao();
                        break;
                }
            } while (menu != 0);

        }
    }
}