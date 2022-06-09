
Console.Write("Digite sua altura em metros: ");
var altura = double.Parse(Console.ReadLine()!);

Console.Write("Digite seu peso em KG: ");
var peso = double.Parse(Console.ReadLine()!);

string RetornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario)
{
    var imc = peso / (altura * altura);

    return imc switch
    {
        < 18.5 => "Anêmico",
        >= 18.5 and < 25 => "Normal",
        >= 25 and < 30 => "Sobrepeso",
        >= 30 and < 40 => "Obesidade",
        >= 40 => "Obesidade Mórbida",
        _ => "Valor não faz sentido"
    };
}

// Utilize a mensagem a seguir como base do retorno esperado:
// Seu diagnóstico é XXXXXX.
Console.WriteLine($"Seu diagnóstico é {RetornarDiagnosticoDoUsuario(altura, peso)}");
