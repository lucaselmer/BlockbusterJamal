using System;
using System.Collections.Generic;
using ClasseCliente;
using ClasseFilme;

namespace ClasseLocacao
{
    public class Locacao
    {
        public static DateTime data = DateTime.Today;
        public String dataCalc = data.ToString();
        private int id = 0;
        private Cliente cliente;
        private String dataLocacao;
        private String dataDevolucao;
        private float valorTotal = 0;
        public List<Filme> filmes = new List<Filme>();
        

        public int getId() {
            return id;
        }
        public Cliente getCliente() {
            return cliente;
        }
        public String getDataDevolucao() {
            return dataDevolucao;
        }
        public String getDataLocacao() {
            return dataLocacao;
        }
        public float getValorTotal() {
            return valorTotal;
        }
        public void setCliente(Cliente cliente) {
            this.cliente = cliente;
        }
        public void setDataDevolucao(String dataDevolucao) {
            this.dataDevolucao = dataDevolucao;
        }
        public void setDataLocacao(String dataLocacao) {
            this.dataLocacao = dataLocacao;
        }
        public void setId(int id) {
            this.id = id;
        }
        public void setValorTotal(float valorTotal) {
            this.valorTotal = valorTotal;
        }

        public Locacao(int id, Cliente cliente){
            this.id = id;
            this.cliente = cliente;
            this.dataLocacao = this.dataCalc.Substring(0,10);
        }
        public void adicionarFilme(Filme filme){
            if(filme.getEstoqueAtual()>1){
                this.filmes.Add(filme);
                filme.filmeLocado();
                cliente.setFilmesLocados(cliente.getFilmesLocados()+1);
            }else{
                Console.WriteLine($"Não foi possivel fazer a locação !! não temos em estoque.{filme.getNome()}");
            }
        }
        public void calcularPrecoFinal(){
            foreach(Filme filme in filmes){
                this.setValorTotal(this.getValorTotal()+filme.getValor());
            }
        }
        public void calculaData(){
            // Calcule o intervalo entre as duas datas.
            System.TimeSpan duration = new System.TimeSpan(this.cliente.getDias(), 0, 0, 0);
            data.Add(duration);
            this.dataDevolucao = data.ToString().Substring(0,10);
        }
    }
}