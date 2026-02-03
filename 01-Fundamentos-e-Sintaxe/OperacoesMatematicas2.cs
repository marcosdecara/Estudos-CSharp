// Contas simples com inteiros
int soma = 7 + 5;
int subtracao = 7 - 5;
int multiplicacao = 7 * 5;

// Aqui notei que 7 divido por 5 deu 1 em vez de 1.4 porque é int
int divisaoInteira = 7 / 5; 

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtração: " + subtracao);
Console.WriteLine("Multiplicação: " + multiplicacao);
Console.WriteLine("Divisão Inteira (perdeu o decimal): " + divisaoInteira);

// Testando com Decimal para ver o numero quebrado
// Tive que colocar o 'm' no final do numero pro C# entender
decimal divisaoCerta = 7.0m / 5; 
Console.WriteLine($"Divisão Certa: {divisaoCerta}");

// Testando o Resto da divisão (%)
Console.WriteLine($"Resto de 7 por 5: {7 % 5}"); // Sobra 2
