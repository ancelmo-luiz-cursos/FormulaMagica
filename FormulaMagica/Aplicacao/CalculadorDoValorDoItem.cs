using FormulaMagica.Dominio;
using FormulaMagica.Historia;

namespace FormulaMagica.Aplicacao
{
    public static class CalculadorDoValorDoItem
    {
        public static decimal Calcular(decimal valor, int validade, int quantidade)
        {
            var item = new Item(valor, validade);

            return new CalcularPrecoDoItem(item).Executar(quantidade);
        }
    }
}
