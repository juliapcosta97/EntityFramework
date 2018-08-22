using System;
using System.Collections.Generic;

namespace EntityFramework.Entidades
{
    public class Pedido
    {
        private int id;
        private DateTime dataPedido;
        private ICollection<ItemPedido> itensPedido;

        public int Id { get => id; set => id = value; }
        public DateTime DataPedido { get => dataPedido; set => dataPedido = value; }
        public ICollection<ItemPedido> ItensPedido { get => itensPedido; set => itensPedido = value; }
    }
}
