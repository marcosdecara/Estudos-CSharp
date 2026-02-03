string nome = "Bob";
int vendas = 7;

// Teste 1: Sem parenteses
// Aqui deu erro na logica porque ele juntou o 7 com o outro 7 virando "77"
Console.WriteLine(nome + " vendeu " + vendas + 7 + " unidades.");

// Teste 2: Com parenteses
// Agora sim, ele somou (7+7) antes de mostrar o texto
Console.WriteLine(nome + " vendeu " + (vendas + 7) + " unidades.");

// Teste 3: Usando interpolacao (o $)
// Achei esse jeito mais facil de ler
Console.WriteLine($"{nome} vendeu {vendas + 7} unidades.");

