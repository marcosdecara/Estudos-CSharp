// --- EXERCÍCIO: Formatando Strings e Tipos de Dados ---

// 1. Definição de Variáveis
// Usamos 'decimal' para precisão (padrão financeiro) e sufixo 'm'
string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

// --- ABORDAGEM 1: Didática (Concatenação) ---
// Útil para entender como o Console.Write funciona (sem pular linha)
Console.WriteLine("--- Versão Didática ---");
Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");
Console.WriteLine(); // Pula linha manualmente

// --- ABORDAGEM 2: Profissional (Interpolação de Strings) ---
// Código mais limpo, legível e moderno (Clean Code)
Console.WriteLine("\n--- Versão Profissional (Market Standard) ---");
Console.WriteLine($"Hello, {name}! You have {messages} messages in your inbox. The temperature is {temperature} celsius.");
