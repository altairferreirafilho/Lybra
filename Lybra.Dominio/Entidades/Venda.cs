using Lybra.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace Lybra.Dominio.Entidades
{
    class Venda
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int ClienteId { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemVenda> ItensVenda { get; set; } //Pedido deve ter pelo menos um item ou muitos intens



    }
}
