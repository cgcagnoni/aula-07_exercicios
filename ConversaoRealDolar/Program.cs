// Cotação do dólar no dia 3 de maio de 2022.
double cotacaoDoDolarHoje = 4.97;
const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;
double valorConvertidoDaCompra;
double valorCompraUsuario;

double converterRealParaDolar(double valorDaCompraEmReais)
{
    valorConvertidoDaCompra =  valorDaCompraEmReais / cotacaoDoDolarHoje;
    return valorConvertidoDaCompra;
}

Console.WriteLine("Digite o valor em Real da sua compra: ");
valorCompraUsuario = Convert.ToDouble(Console.ReadLine());

var valorConvertido = converterRealParaDolar(valorCompraUsuario);


if (valorConvertido < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
{
    Console.WriteLine("A compra mínima permitida é de USD$ " + VALOR_MINIMO_DE_COMPRA_EM_DOLAR + " e o valor convertido atual de sua compra é de USD$ " + valorConvertido);
} else if (valorConvertido > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
{
    Console.WriteLine("A compra máxima permitida é de USD$ " + VALOR_MAXIMO_DE_COMPRA_EM_DOLAR + " e o valor convertido atual de sua compra é de USD$ " + valorConvertido);
} else
{
    Console.WriteLine("Você pode comprar USD$ " + valorConvertido);
}

