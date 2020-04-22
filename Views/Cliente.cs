using System;
using Models;
using Controllers;
using System.Linq;

namespace View{
    
    public class ClienteView {
        public static void CadastrarCliente(){
            Console.WriteLine("####### Cadastrar um novo Cliente #######");
            Console.WriteLine("Nome Completo do cliente: ");
            string nomeCliente = Console.ReadLine();
            Console.WriteLine("\nData de Nascimento: ");
            Console.WriteLine("** Devera informar data no formato (dd/mm/yyyy) **");
            string dataNascimento = Console.ReadLine();
            Console.WriteLine("\nInforme o CPF: ");
            string cpfCLiente = Console.ReadLine();
            Console.WriteLine("\nDias para devolver o filme: ");
            int diasDevolucao = Convert.ToInt32(Console.ReadLine());
            ClienteController.CadastrarCliente(nomeCliente, dataNascimento, cpfCLiente, diasDevolucao);
        }
        public static void ListarClientes(){
            Console.WriteLine("################## Lista de cliente ##################");
            ClienteController.GetClientes().ForEach(cliente => Console.WriteLine(cliente));
        }
        // Consulting a customer by ID (LINQ)
        public static void ConsultarCliente(){
            Console.WriteLine("Informe o ID do Cliente: ");
            int idCliente = Convert.ToInt32(Console.ReadLine());
            try {
                ClienteModels cliente = (from cliente1 in ClienteController.GetClientes() where cliente1.IdCliente == idCliente select cliente1).First();
                Console.WriteLine("################## Consultar Cliente cadastrado ##################");
                Console.WriteLine(cliente.ToString());
            }
            catch{
                Console.WriteLine("#### Cliente informado não existe ####");
                Console.WriteLine("#### Favor verificar novamente as informações passadas ####");
            }
        }
    }
}