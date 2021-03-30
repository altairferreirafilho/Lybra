using Lybra.Dominio.Enumerados;

namespace Lybra.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhDInheiro
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Dinheiro; }
        }

        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        public bool EhCartaoDebito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoDebito; }
        }

        public bool EhDeposito
        { 
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        public bool EhAPrazo
        { 
            get { return Id == (int)TipoFormaPagamentoEnum.APrazo; }
        }

        public bool NaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }



    }
}
