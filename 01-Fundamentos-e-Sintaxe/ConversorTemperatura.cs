int fahrenheit = 94;

// Tive que usar 'decimal' e colocar o 'm' nos numeros.
// Se fizer só 5 / 9 o C# arredonda pra 0 e a conta zera.
decimal celsius = (fahrenheit - 32m) * (5m / 9m);

Console.WriteLine($"A temperatura é {celsius} Celsius.");
