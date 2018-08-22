namespace EntityFramework.Entidades
{
    public class Produto
    {
        private int id;
        private string descricao;
        private string nome;
        private decimal preco;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Preco { get => preco; set => preco = value; }
    }
}
