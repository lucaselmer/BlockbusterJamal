using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace View{
    public class LocacaoView{
        public static void ListarLocacao(){
            Console.WriteLine("\n#################### Lista de locações ####################");
            List<LocacaoModels> locacoes = LocacaoController.GetLocacao();

            locacoes.ForEach(locacao => Console.WriteLine(locacao));
        }
        public static void CadastrarLocacao(){
            Console.WriteLine("####### Cadastrar Locação #######");
            List<ClienteModels> clientes = ClienteController.GetClientes();
            List<FilmeModels> filmes = FilmeController.GetFilmes();

            int idCliente = 0;

            Console.WriteLine("\nInforme o ID do Cliente:");
            idCliente = Convert.ToInt32(Console.ReadLine());

            if (idCliente != 0){
                ClienteModels cliente = clientes.Find(cliente => cliente.IdCliente == idCliente);
                LocacaoModels locacao = LocacaoController.addLocacao(cliente);

                int idFilme = 0;

                // Continua adicionando em locação até ser digitado 0.                     
                do{
                    Console.WriteLine("\nInforme o ID Filme: ");
                    Console.WriteLine("Caso já tenha informado todos filmes, digite 0 para finalizar");
                    idFilme = Convert.ToInt32(Console.ReadLine());

                    if (idFilme != 0){ 
                        FilmeModels filme = filmes.Find(filme => filme.IdFilme == idFilme);

                        locacao.AdicionarFilme(filme);
                    }
                } while (idFilme != 0); // While até o id do filme for 0.
            }
        }
        public static void ConsultarLocacao(){
            Console.WriteLine("Informe o ID da Locação: ");
            int idLocacao = Convert.ToInt32(Console.ReadLine());

            try{
                LocacaoModels locacao =
                (from locacao1 in LocacaoController.GetLocacao()
                 where locacao1.IdLocacao == idLocacao
                 select locacao1).First();

                Console.WriteLine("\n################### Consulta Locações ####################");
                Console.WriteLine(locacao.ToString());
            }
            catch{
                Console.WriteLine("#### Locação informado não existe ####");
                Console.WriteLine("#### Favor verificar novamente as informações passadas ####");
            }
        }
    }
}