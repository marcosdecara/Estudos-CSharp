// --- OPERAÇÕES MATEMÁTICAS BÁSICAS ---

int primeiroNumero = 18;
int segundoNumero = 4;

Console.WriteLine($"--- Calculando com {primeiroNumero} e {segundoNumero} ---");

// 1. Soma (+)
// Posso fazer a conta direto dentro da interpolação
Console.WriteLine($"Soma: {primeiroNumero + segundoNumero}");

// 2. Subtração (-)
Console.WriteLine($"Subtração: {primeiroNumero - segundoNumero}");

// 3. Multiplicação (*)
Console.WriteLine($"Multiplicação: {primeiroNumero * segundoNumero}");

// 4. Divisão (/)
// Obs: Como são números inteiros (int), o resultado será 4, e não 4.5
Console.WriteLine($"Divisão Inteira: {primeiroNumero / segundoNumero}");

// 5. Resto da Divisão (%)
// Mostra o que sobrou da divisão (18 dividido por 4 dá 4 e sobra 2)
Console.WriteLine($"Resto da Divisão: {primeiroNumero % segundoNumero}");

/*
   SAÍDA ESPERADA:
   Soma: 22
   Subtração: 14
   Multiplicação: 72
   Divisão Inteira: 4
   Resto da Divisão: 2
*/