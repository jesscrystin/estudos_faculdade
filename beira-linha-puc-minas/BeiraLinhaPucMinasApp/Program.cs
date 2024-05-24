using System.Numerics;

Console.WriteLine("Digite um número para calcular seu fatorial: ");
BigInteger numero = BigInteger.Parse(Console.ReadLine());

BigInteger resultado = numero;

for (int contador = 1; contador < numero; contador++)
{
    resultado = resultado * (numero - contador);
}

Console.WriteLine(resultado);
