using System;

namespace pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
        }

        public interface IPagamento
        {
            void Pagar();

        }

        class Pagamento : IPagamento
        {
            protected DateTime Vencimento = DateTime.Now;

            public virtual void Pagar()
            {
                Console.WriteLine("Validar vencimento do pagamento - " + this.Vencimento);
            }

        }

        class PagamentoBoleto : Pagamento
        {
            private Guid NumeroBoleto = Guid.NewGuid();

            public override void Pagar()
            {
                base.Pagar();
                Console.WriteLine($"Pagamento por boleto com o numero : {this.NumeroBoleto}");
            }
        }



    }
}