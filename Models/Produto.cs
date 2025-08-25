namespace LojaGilmarF.Models
{
    public class Produto
    {
        public int Id { get; set; }              // Identificador único do produto
        public string Nome { get; set; }         // Nome do produto
        public string Descricao { get; set; }    // Descrição do produto
        public decimal Preco { get; set; }       // Preço do produto
        public string ImagemUrl { get; set; }    // Caminho/URL da imagem do produto
    }
}
