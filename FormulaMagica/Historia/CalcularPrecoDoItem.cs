using FormulaMagica.Dominio;

namespace FormulaMagica.Historia
{
    public class CalcularPrecoDoItem
    {
        private readonly Item _item;
        public CalcularPrecoDoItem(Item item)
        {
            _item = item;
        }

        public decimal Executar(int quantidade)
        {
            var precoCusto = _item.CalularPreco(_item.Valor, _item.Validade);

            return precoCusto * quantidade;
        }
    }
}
