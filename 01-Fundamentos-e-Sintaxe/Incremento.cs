int valor = 1;

// Jeito basico
valor = valor + 1;
Console.WriteLine("Primeiro aumento: " + valor); // foi pra 2

// Jeito mais rapido
valor += 1;
Console.WriteLine("Segundo aumento: " + valor); // foi pra 3

// Usando o ++
valor++;
Console.WriteLine("Terceiro aumento: " + valor); // foi pra 4

// A DIFERENÇA DO ++ ANTES E DEPOIS
int numero = 1;

// Colocando depois (numero++): Ele mostra, e so depois aumenta
Console.WriteLine($"Primeiro mostra: {numero++}"); 

// Colocando antes (++numero): Ele aumenta primeiro, depois mostra
Console.WriteLine($"Agora ja aumenta direto: {++numero}");
