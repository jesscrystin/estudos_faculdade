
/*  int idade = 26;
string nome = "Jéssica Melo";

//Concatenação
Console.WriteLine("\nMeu nome é " + nome + " e tenho " + idade + " anos de idade.");
//Placeholder
Console.WriteLine("\nMeu nome é {0} e tenho {1} anos de idade.", nome, idade);
//Interpolação
Console.WriteLine($"\nMeu nome é {nome} e tenho {idade} anos de idade.");
*/

/* int n1, n2;
double n3, n4;
float n5;
string s;
bool b1, b2;

//Leitura de Inteiros
Console.Write("Digite um número inteito: ");
n1 = int.Parse(Console.ReadLine());
Console.Write("Digite outro número inteiro: ");
n2 = Convert.ToInt32(Console.ReadLine());
//Leitura de valores ponto-flutuante
Console.Write("Digite um número real: ");
n3 = double.Parse(Console.ReadLine());
Console.Write("Digite outro número real: ");
n4 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite mais um número real: ");
n5 = float.Parse(Console.ReadLine());
//Leitura de String
Console.Write("Digite uma string: ");
s = Console.ReadLine();
//Leitura de Booleano
Console.Write("Digite um booleano (digite true ou false): ");
b1 = bool.Parse(Console.ReadLine()); */

/* int n1, n2, soma;
double media;
Console.Write("Digite um número: ");
n1 = int.Parse(Console.ReadLine());
Console.Write("Digite outro número: ");
n2 = int.Parse(Console.ReadLine());
soma = n1 + n2;
media = soma / 2;
Console.Write("Soma = " + soma);
Console.Write("\nMedia = " + media); */

int preinc = 7, posinc = 7, predec = 7, posdec = 7;
Console.WriteLine($"pré-incremento = {++preinc}");
Console.WriteLine($"pós-incremento = {posinc++}");
Console.WriteLine($"pré-decremento = {--predec}");
Console.WriteLine($"pós-decremento = {posdec--}");
Console.WriteLine("\nREIMPRIMINDO");
Console.WriteLine($"pré-incremento = {preinc}");
Console.WriteLine($"pós-incremento = {posinc}");
Console.WriteLine($"pré-decremento = {predec}");
Console.WriteLine($"pós-decremento = {posdec}");