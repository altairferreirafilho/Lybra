using System.Collections.Generic;

namespace Lybra.Dominio.Entidades
{
    class Cliente
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public int CPF { get; set; }
        public int Telefone { get; set; }
        public ICollection<Venda> Vendas { get; set; }  //Cliente pode ter várias vendas ou nenhuma
    }
}
