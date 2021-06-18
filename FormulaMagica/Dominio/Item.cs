
namespace FormulaMagica.Dominio
{
    public class Item
    {
        public Item(decimal valor, int validade)
        {
            Valor = valor;
            Validade = validade;
        }

        public decimal Valor { get; private set; }
        public int Validade { get; private set; }


        public decimal CalularPreco(decimal valor, int validade)
        {

            if (validade <= 10)
            {
                var percentualDesconto = 50 / validade;
                var total = valor - ((valor * percentualDesconto) / 100);

                return total;
            }

            return valor;
        }
    }
}
