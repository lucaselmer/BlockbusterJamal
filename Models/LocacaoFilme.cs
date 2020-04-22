using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models{
    public class LocacaoFilmeModels{ 
        [Key] // Chave principal
        public int Id { get; set; }

        [ForeignKey("locacoes")] // Chave estrangeira
        public int IdLocacao { get; set; }

        public virtual LocacaoModels Locacao { get; set; }

        [ForeignKey("filmes")] // Chave estrangeira
        public int IdFilme { get; set; }
        
        public virtual FilmeModels Filme { get; set; }

    }
}