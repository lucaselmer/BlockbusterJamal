using System;
using Models;
using Controllers;
using System.Linq;

namespace View{
    public class FilmeView{
        public static void CadastrarFilme(){
        Console.WriteLine("####### Cadastrar Filme #######");
        Console.WriteLine("Título do filme: ");
        string titulo = Console.ReadLine();
        Console.WriteLine("\nData de Lançamento do filme : ");
        Console.WriteLine("** Obs: Devera informar data no formato (dd/mm/yyyy) **");
        string dataLancamento = Console.ReadLine();
        Console.WriteLine("\nSinopse do filme: ");
        string sinopse = Console.ReadLine();
        Console.WriteLine("\nValor para Locação do filme: ");
        double valorLocacaoFilme = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nQuantidade total disponivel em Estoque : ");
        int estoqueFilme = Convert.ToInt32(Console.ReadLine());
        
        FilmeController.CadastrarFilme(titulo, dataLancamento, sinopse, valorLocacaoFilme, estoqueFilme);
        }
        public static void ListarFilmes(){
            Console.WriteLine("################# Lista de filmes ###################");
            FilmeController.GetFilmes().ForEach(filme => Console.WriteLine(filme));
        }
        public static void ConsultarFilme(){
            Console.WriteLine("Informe o ID do Filme: ");
            int idFilme = Convert.ToInt32(Console.ReadLine());
            try{
                FilmeModels filme = (from filme1 in FilmeController.GetFilmes() where filme1.IdFilme == idFilme select filme1).First();
                Console.WriteLine("################### Consultar Filmes ####################");
                Console.WriteLine(filme.ToString());
            }
            catch{
                Console.WriteLine("#### Filme informado não existe ####");
                Console.WriteLine("#### Favor verificar novamente as informações passadas ####");
            }
        }
    }
}