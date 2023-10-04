using csharp_fundamentos.models;

Pessoa p = new Pessoa();
p.Nome = "Gabriel";
p.Idade = 25;
p.Apresentar();

string palavra = "texto";
char letra = 'c';
bool tipo = false;
int numero = 123;
decimal numeroDecimal = 12.3M;
float precisaoSimples = 12.3456F;
double precisaoDupla = 123456.7899987;

Console.WriteLine($"Palavra -> {palavra}");
Console.WriteLine($"Letra -> {letra}");
Console.WriteLine($"Booleano -> {tipo}");
Console.WriteLine($"Inteiro -> {numero}");
Console.WriteLine($"Decimal -> {numeroDecimal}");
Console.WriteLine($"Precisão simples -> {precisaoSimples}");
Console.WriteLine($"Precisão dupla -> {precisaoDupla.ToString("0.000")}"); //Controlando o número de casas decimais

DateTime dataAtual = DateTime.Now;  // Data atual da máquina
DateTime data2 = DateTime.Now.AddDays(5);   //Adiciona 5 dias à data atual

Console.WriteLine($"Data atual: {dataAtual}");
Console.WriteLine($"Nova data: {data2}");
Console.WriteLine($"Data formatada: {dataAtual.ToString("dd/MM/yy")}");