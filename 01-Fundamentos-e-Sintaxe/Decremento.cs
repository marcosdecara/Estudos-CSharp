int vida = 10;
Console.WriteLine("Vida inicial: " + vida);

// Forma 1: Do jeito tradicional
vida = vida - 1;
Console.WriteLine("Tomou dano (forma 1): " + vida); // Vai pra 9

// Forma 2: Usando o -= (mais rapido de escrever)
vida -= 1;
Console.WriteLine("Tomou dano (forma 2): " + vida); // Vai pra 8

// Forma 3: Usando o -- (Decremento)
vida--;
Console.WriteLine("Tomou dano (usando --): " + vida); // Vai pra 7

// TESTE: A ordem do -- importa?
int municao = 5;

// Aqui eu coloquei o -- DEPOIS. 
// Ele imprime o 5 primeiro, e SÓ DEPOIS diminui a munição.
Console.WriteLine($"Atirei! Munição mostrada: {municao--}");

// Aqui a gente vê que agora a munição caiu pra 4
Console.WriteLine($"Munição real no pente agora: {municao}");
