// --- RESUMO DO DIA: Manipulação de Strings e Caracteres Especiais ---

// 1. Concatenação (Jeito Antigo) vs Interpolação (Jeito Novo)
string nome = "Marcos";
string cargo = "Desenvolvedor C#";

// Antigo (Sinal de +)
Console.WriteLine("1. Antigo: Olá, " + nome + ". Bem-vindo ao cargo de " + cargo + ".");

// Novo (Sinal de $) - Mais limpo!
Console.WriteLine($"2. Novo:   Olá, {nome}. Bem-vindo ao cargo de {cargo}.");


// 2. Sequências de Escape (A barra invertida \)
Console.WriteLine("\n--- Testando Escapes ---");
Console.WriteLine("Pular linha: \nEssa frase está na linha de baixo.");
Console.WriteLine("Tabulação: \tEssa frase está afastada para a direita.");
Console.WriteLine("Aspas: \"Isso é uma citação entre aspas\".");


// 3. Verbatim Literal (O Arroba @)
// Útil para caminhos de arquivos no Windows, pois ignora as barras invertidas.
Console.WriteLine("\n--- Testando Verbatim (@) ---");
// Sem @ (Dá erro ou precisa de barra dupla \\)
// Com @ (Funciona perfeitamente)
Console.WriteLine(@"C:\Usuarios\Marcos\Projetos\Estudos-CSharp");


// 4. O Grande Desafio (Unicode + Interpolação + Verbatim)
Console.WriteLine("\n--- Desafio Projeto ACME ---");
string projeto = "ACME";
string fraseRussa = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c"; // Significa "View" em Russo

// O Combo $@ permite usar variáveis {} E barras \ ao mesmo tempo
string caminhoIngles = $@"c:\Exercise\{projeto}\data.txt";
string caminhoRusso = $@"c:\Exercise\{projeto}\ru-RU\data.txt";

Console.WriteLine($"View English output:\n\t{caminhoIngles}\n");
Console.WriteLine($"{fraseRussa} Russian output:\n\t{caminhoRusso}");
