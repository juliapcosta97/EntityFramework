using System.Collections.Generic;

namespace EntityFramework.Entidades
{
    public class ItemPedido
    {
        private int id;
        private Produto produto;
        private int quantidade;
       

        public int Id { get => id; set => id = value; }
        public Produto Produto { get => produto; set => produto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
