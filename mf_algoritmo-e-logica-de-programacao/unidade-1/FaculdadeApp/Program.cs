
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

/* int preinc = 7, posinc = 7, predec = 7, posdec = 7;
Console.WriteLine($"pré-incremento = {++preinc}");
Console.WriteLine($"pós-incremento = {posinc++}");
Console.WriteLine($"pré-decremento = {--predec}");
Console.WriteLine($"pós-decremento = {posdec--}");
Console.WriteLine("\nREIMPRIMINDO");
Console.WriteLine($"pré-incremento = {preinc}");
Console.WriteLine($"pós-incremento = {posinc}");
Console.WriteLine($"pré-decremento = {predec}");
Console.WriteLine($"pós-decremento = {posdec}"); */

/* string nome;
double altura, peso;

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("\nDigite sua altura em metros: ");
altura = double.Parse(Console.ReadLine());
Console.Write("Digite seu peso em kg: ");
peso = double.Parse(Console.ReadLine());

altura = Math.Pow(altura, 2);
double imc = peso / altura;

Console.WriteLine(nome + " o seu IMC é: " + imc); */

/* int a = 5, b = 2, c;
int Soma, Subt, Mult, Quociente, Resto;
double DivExata, RaizQuadrada, Quadrado, Cubo, RaizCubica;

//Cálculos
Soma = a + b;
Subt = a - b;
Mult = a * b;
Quociente = a / b;
Resto = a % b;
DivExata = 9 / 2.0;
RaizQuadrada = Math.Sqrt(36);
Quadrado = Math.Pow(a, b);
c = b + 1;
Cubo = Math.Pow(c, c);
RaizCubica = Math.Pow(125, 1 / 3.0);

//Impressão dos resultados
Console.WriteLine($"{a} + {b} = {Soma}");
Console.WriteLine($"{a} - {b} = {Subt}");
Console.WriteLine($"{a} * {b} = {Mult}");
Console.WriteLine($"{a} / {b} = {Quociente}");
Console.WriteLine($"{a} % {b} = {Resto}");
Console.WriteLine($"9 / 2.0 = {DivExata}");
Console.WriteLine($"A raiz quadrada de 36 = {RaizQuadrada}");
Console.WriteLine($"{a} elevado a {b} = {Quadrado}");
Console.WriteLine($"{c} elevado a {c} = {Cubo}");
Console.WriteLine($"A raiz cubica de 125 = {RaizCubica}");
 */

/* //Type casting (conversão explícita)
int x = 5, y = 2;

float f = (float)x / y;
double d = x / (double)y;
 */

// Atividade 1 - Faça um programa que leia 5 números inteitos diferentes informandos pelo usuário e calcule e imprima a soma ea média aritmética destes números. 

//Fórmulas: SOMA + N1 + N2 + N3 + N4 + N5 // MEDIA = SOMA/5

/* //Declaração de dados
int n1, n2, n3, n4, n5, Soma;
double Media;

//Entrada de dados
Console.WriteLine("Digite um número inteiro: ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número inteiro: ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número inteiro: ");
n3 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número inteiro: ");
n4 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número inteiro: ");
n5 = int.Parse(Console.ReadLine());

//Cálculo / Processamento
Soma = n1 + n2 + n3 + n4 + n5;
Media = (double)Soma / 5.0;

//Saída de dados
Console.WriteLine($"A média de {Soma} é igual a {Media}"); */

//Atividade 2 - Faça um algoritmo que calcule e imprima o valor da hipotenusa de m triângulo retângulo. Os valores dos catetos serão informados pelo usuário.

/* //Declaração de variáveis
double Cat1, Cat2, Hipotenusa;

//Entrada de dados
Console.Write("Informe o valor do 1º cateto: ");
Cat1 = double.Parse(Console.ReadLine());
Console.Write("Informe o valor d0 2º cateto: ");
Cat2 = double.Parse(Console.ReadLine());

//Cálculo da hipotenusa
Hipotenusa = Math.Sqrt(Math.Pow(Cat1, 2) + Math.Pow(Cat2, 2));

//Saída / impressão do resultado
Console.WriteLine($"O valor da Hipotenusa de é {Hipotenusa}"); */

/* //Declaração de variáveis
double Salario, Inss;

//Entrada de dados
Console.WriteLine("Valor do seu salário: ");
Salario = double.Parse(Console.ReadLine());

//Cálculo
Inss = Salario * 0.11;

//Saída / impressão do resultado
Console.WriteLine($"O valor do INSS = R$ {Inss:0.00}"); */

/* //Condicional simples
int Nota;

Console.Write("Digite a nota do aluno : ");

Nota = int.Parse(Console.ReadLine());

if (Nota >= 60)
    Console.WriteLine("Aprovado."); */

/* //Condicional composta
int Nota;

Console.Write("Digite a nota do aluno: ");

Nota = int.Parse(Console.ReadLine());

// comando if = se 
if (Nota >= 60)
    Console.WriteLine("Aprovado.");

//cláusula else = se não
else
    Console.WriteLine("Reprovado."); 
*/

/* int Nota;

Console.Write("Digite a nota do aluno: ");

Nota = int.Parse(Console.ReadLine());

// {} obrigatório para mais de um comando 
if (Nota >= 60)
{
    Console.WriteLine("Aprovado.");
    Console.WriteLine("Parabéns!!!");
}

else
{
    Console.WriteLine("Reprovado.");
    Console.WriteLine("Será necessario fazer uma reavaliação!!!"); 
}*/

//Atividade 3 - Faça um programa em C# para calcular e imprimir o valor a ser descontado do INSS no salário de um empregado ultilizando a tabela abaixo. O usuário fornecerá o sálario.

/* double Salario, Inss;

Console.Write("Preencha seu salário: ");
Salario = double.Parse(Console.ReadLine());

if (Salario <= 1000)
    Inss = Salario * 0.08;
else
    Inss = Salario * 0.1;

Console.WriteLine($"Desconto do INSS é de R$ {Inss:0.00}."); */

/* double Salario, Inss;

Console.Write("Preencha seu salário: ");
Salario = double.Parse(Console.ReadLine());

{
    if (Salario <= 1000)
        Inss = Salario * 0.08;
    else
    {
        if (Salario <= 1800)

            Inss = Salario * 0.1;
        else
            Inss = Salario * 0.12;
    }
}

Console.WriteLine($"Desconto do INSS é de R$ {Inss:0.00}."); */


/* int Mes;

Console.Write("Digite o número do mês: ");
Mes = int.Parse(Console.ReadLine());

string MesStr;

switch (Mes)
{
    case 1:
        MesStr = "Janeiro";
        break;
    case 2:
        MesStr = "Fevereiro";
        break;
    case 3:
        MesStr = "Março";
        break;
    case 4:
        MesStr = "Abril";
        break;
    case 5:
        MesStr = "Maio";
        break;
    case 6:
        MesStr = "Junho";
        break;
    case 7:
        MesStr = "Julho";
        break;
    case 8:
        MesStr = "Agosto";
        break;
    case 9:
        MesStr = "Setembro";
        break;
    case 10:
        MesStr = "Outubro";
        break;
    case 11:
        MesStr = "Novembro";
        break;
    case 12:
        MesStr = "Dezembro";
        break;
    default:
        MesStr = "Mês inválido";
        break;
} */

// Exemplo: Operador condicional/ternário

/* bool Passou;
double Nota;

{
    if (Nota >= 60)
        Passou = true;
    else
        Passou = false;
}

// Essa estrutura pode ser subistituída pelo operador ternário

Passou = Nota >= 60 ? true : false;

// Você pode usar parênteses para tornar a leitura mais legível

Passou = (Nota >= 60) ? true : false;
Passou = (Nota >= 60 ? true : false);
 */

/* int a = 5, b = 7, c = 3;

Console.WriteLine((a > b ? (a > c ? a : b) : (a > c ? c : a + b + c)));
 */

/* double Raiz, Numero;

Console.Write("Digite um número: ");
Numero = double.Parse(Console.ReadLine());

Raiz = Math.Sqrt(Numero);

Console.Write($"A raiz quadrada de {Numero} = {Raiz}");

 */

/* 

// while = ENQUANTO

double Raiz, Numero;

Console.Write("Digite um número: ");
Numero = double.Parse(Console.ReadLine());

while (Numero > 0)
{
    Raiz = Math.Sqrt(Numero);
    Console.WriteLine($"A raiz quadrada de {Numero} = {Raiz}");
    Console.Write("\nDigite um número: ");
    Numero = double.Parse(Console.ReadLine());
} */

// do while = FAÇA ENQUANTO

/* double Raiz, Numero;

// calcula a raiz quadrada enquanto o número digitado for maior que 0(zero)

do
{
    Console.Write("\nDigite um número: ");
    Numero = double.Parse(Console.ReadLine());
    Raiz = Math.Sqrt(Numero);
    Console.WriteLine($"A raiz quadrada de {Numero} = {Raiz}");
} while (Numero > 0);
 */

/* double Raiz, Numero;

do
{
    Console.Write("Digite um número: ");
    Numero = double.Parse(Console.ReadLine());

    if (Numero > 0)
    {
        Raiz = Math.Sqrt(Numero);
        Console.WriteLine($"A raiz quadrada de {Numero} = {Raiz}");
    }
} while (Numero > 0);
 */


/* double cont = 1, raiz;
// Calcular a raiz quadrada de 10 numeros
while (cont <= 10)
{
    Console.Write("Digite um número: ");
    cont = double.Parse(Console.ReadLine());
    raiz = Math.Sqrt(cont);
    Console.WriteLine($"A raiz quadrada de {cont} = {raiz}");
    cont += 1; // ou cont++ ou cont + 1
}
 */
/* double cont, raiz;
// Calcular a raiz quadrada de 10 numeros
for (cont = 1; cont <= 10; cont++)// ou cont++ ou cont + 1
{
    Console.Write("Digite um número: ");
    cont = double.Parse(Console.ReadLine());
    raiz = Math.Sqrt(cont);
    Console.WriteLine($"A raiz quadrada de {cont} = {raiz}");
} */

/* int a = 1, b = a, c = 2, d = c;
for (int cont = 1; cont < 5; cont += 2)
{
    a += b;
    b -= c;
    c += d;
    d -= a;
}
Console.WriteLine(a + ", " + b + ", " + c + ", " + d); */


/* // Exemplo contador

int positivos = 0; // contador de números positivos
int num;

Console.Write("Digite um número entre -100 e 100: ");
num = int.Parse(Console.ReadLine());
while (num >= -100 && num <= 100)
{
    if (num > 0)
        positivos += 1;
    Console.Write("Digite um número entre -100 e 100: ");
    num = int.Parse(Console.ReadLine());
}

Console.Write($"Foram digitados {positivos} números positivos"); */

// Exemplo contador

/* int pares = 0; // contador de números pares
int num;

Console.Write("Digite um número positivo: ");
num = int.Parse(Console.ReadLine());
while (num >= 0)
{
    if (num % 2 == 0)
        pares += 1;
    Console.Write("Digite um número positivo: ");
    num = int.Parse(Console.ReadLine());
}

Console.Write($"Foram digitados {pares} números pares"); */

/* 
// Jeito errado

int pares = 0, impares = 0, num; // contador de números pares e impares

Console.Write("Digite um número positivo: ");
num = int.Parse(Console.ReadLine());

while (num >= 0)
{
    if (num % 2 == 0)
    {
        pares += 1;
    }
    else
    {
        impares++;
    }
    Console.Write("Digite um número positivo: ");
    num = int.Parse(Console.ReadLine());
}

Console.Write($"Foram digitados {pares} números pares e {impares} impares"); */


/*
// Jeito certo

string nome; 
int nota = 0, aprov = 0, reprov = 0;

for (int i = 1; i <= 5; i += 1)
{
    Console.Write("Digite o nome do aluno: ");
    nome = Console.ReadLine();
    Console.Write("Digite a nota: ");
    nota = int.Parse(Console.ReadLine());
    
    if (nota >= 60)
        aprov++;
    else
        reprov++;
}

Console.Write($"{aprov} alunos foram aprovados e {reprov} foram reprovados"); */

/*// 

exerc 1 

for (int aux = 117; aux <= 131; aux += 1)
{
    Console.WriteLine("Jéssica Cristina Araújo Lima de Melo");
}
 */

/* int num;

Console.Write("Digite um numero: ");
num = int.Parse(Console.ReadLine());

for (int mult = 1; mult <= 10; mult++)
{
    int result = num * mult;
    Console.WriteLine(num + " x " + mult + " = " + result);
} */


/* for (int num = 1; num <= 10; num++)
{
    for (int mult = 1; mult <= 10; mult++)
    {
        int result = num * mult;
        Console.WriteLine(num + " x " + mult + " = " + result);
    }
    Console.WriteLine();
} */

// faça um programa que calcule a área das circunferências com raio variando entre 1 e 15.

/* double area, pi = 3.14;

for (float r = 1; r <= 15; r++)
{
    area = pi * Math.Pow(r, 2);
    Console.WriteLine($"A área da circuferência equivale a {area}.");
} */

//faça um programa que calcule a área das circunferências com raio variando entre x e y, sendo x e y informados pelo usuário.

/* double pi = 3.14, area, x, y;

Console.WriteLine("Informe o valor inicial da variação do raio: ");
x = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor de final da variação do raio: ");
y = double.Parse(Console.ReadLine());

for (double i = x; i <= y; i++)
{
    area = pi * Math.Pow(i, 2);
    Console.WriteLine($"A área da circuferência equivale a {area}.");
} */

/* static void ImprimeCabecalho(string nome, char sexo)
{
    Console.WriteLine("****************");
    Console.WriteLine("* Algoritmos e *");
    Console.WriteLine("*   Lógica de  *");
    Console.WriteLine("*  Programação *");
    Console.WriteLine("****************");

    if (sexo == 'F' || sexo == 'f')
        Console.WriteLine($"Nome da aluna: {nome}");
    else
        Console.WriteLine($"Nome do aluno: {nome}");
}
 */

/* static int Max(int a, int b)
{
    return (a > b) ? a : b;
}

static int Min(int a, int b)
{
    return (a < b) ? a : b;
}

static int Diferenca(int a, int b)
{
    return Max(a, b) - Min(a, b);
}

int v1 = 13, v2 = 38;
Console.WriteLine($"A diferença entre {v1} e {v2} = {Diferenca(v1, v2)}");
Console.WriteLine($"A diferença entre {v2} e {v1} = {Diferenca(v2, v1)}");
 */
