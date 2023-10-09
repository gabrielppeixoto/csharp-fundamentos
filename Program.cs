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

//------------------------------ Tipos de Operadores -------------------------------------------------------------------
int a = 10;
int b = 234;
int c = a + b;
c += 5;
c += 5;

//Converter string para inteiro, duas opções; diferença está no tratamento de valores nulos
string d = "5";
int dInt = Convert.ToInt32(d); // Se nulo, converte o valor para 0
int dInt2 = int.Parse(d);       // Se nulo, lança uma ArgumentNullException
int.TryParse(d, out int h);

//Cast implícito
int e = 63;
double f = e;
long g = e;

//Operadores condicionais
int quantidadeEmEstoque = 14;
int quantidadeCompra = 4;

if(quantidadeCompra == 0)
{
    Console.WriteLine("Compra inválida.");
}
else if(quantidadeCompra <= quantidadeEmEstoque)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Não se poderealizar a venda.");
}

Console.WriteLine("Digite uma letra: ");
string letra2 = Console.ReadLine();

switch (letra2)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é uma vogal");
        break;
}

//Operadores lógicos
bool i = true;
bool j = false;
bool operacaoOr = i || j;
bool operacaoAnd = i && j;
bool operacaoNot = !i;

// --------------------------------- Estruturas de repetição ---------------------------------------
int numero2 = 10;
for (int jota = 0; jota < numero2; jota++)
{
    Console.WriteLine($"{jota}");
}

while (numero2 >= 5)
{
    Console.WriteLine($"{numero2} -- Testando while");
    numero2--;
    if(numero2 == 6)
    {
        break;
    }
    else if(numero2 == 7)
    {
        continue;
    }
}

int numero3 = 15;
do
{
    Console.WriteLine($"{numero3} -- Testando do while");
    numero3--;
} while (numero3 > 6);