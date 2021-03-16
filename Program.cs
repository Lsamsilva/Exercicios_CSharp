using System;

namespace exercicios_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-Faça um algoritmo que receba 2 números inteiros e apresente a soma desses números.
            //Declaração de Variáveis
            int n1, n2, soma;
            //Entrada de Dados
            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            //Processamento
            soma = n1 + n2;
            //Saída de Dados
            Console.WriteLine("O valor da soma dos números digitados é " + soma);

            Console.ReadKey();

            //2-Faça um algoritmo que receba 2 números inteiros e mostre os dois números.
            //Declaração de Variáveis
            int a, b;
            //Entrada de Dados
            Console.WriteLine("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());
            //Saída de Dados
            Console.Write("Os números digitados foram: " + a + " e " +b);

            Console.ReadKey();

            //3-Faça um algoritmo que receba 2 números e apresente a multiplicação dos dois números
            //Declaração de Variáveis
            int c, d,mult;
            //Entrada de Dados
            Console.WriteLine("Digite o primeiro número: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            d = int.Parse(Console.ReadLine());
            //Processamento
            mult = n1 * n2;
            //Saída de Dados
            Console.WriteLine("A multiplicação "+c+" X "+d+" é : "+mult);

            Console.ReadKey();

             //4-Faça um algoritmo que leia uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            //Declaração de Variáveis
            float F, C;
            //Entrada de Dados
            Console.WriteLine("Digite o valor da temperatura em Celsius");
            C = float.Parse(Console.ReadLine());
            //Processamento
            F = ((9 * C) / 5 + 32f);
            //Saída de Dados
            Console.WriteLine("A temperatura digitada é igual a " + F + " graus Fahrenheit") ;

            Console.ReadKey();

            //5-Faça um algoritmo que leia uma temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsius. 
            //Declaração de Variáveis
            float F1, C1;
            //Entrada de Dados
            Console.WriteLine("Digite o valor da temperatura em Fahrenheit");
            F1 = float.Parse(Console.ReadLine());
            //Processamento
            C1 = (F1 - 32f) * 5 / 9;
            //Saída de Dados
            Console.WriteLine("A temperatura digitada é igual a " + C + " graus Celsius");

            Console.ReadKey();

            //6-Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
            //VOLUME < --3.14159 * RAIO2 * ALTURA.
            //Declaração de Variáveis
            float PI = 3.14159f;
            float V, R, H;
            //Entrada de Dados
            Console.WriteLine("Cálculo do Volume de uma lata de óleo.");
            Console.WriteLine("Digite o valor do raio da lata em cm: ");
            R = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura da lata em cm: ");
            H = float.Parse(Console.ReadLine());
            //Processamento
            V = (PI) * (R * R) * H;
            //Saída de Dados
            Console.WriteLine("O Volume da Lata de Óleo é "+V+" cm³.");

            Console.ReadKey();

            
            //7-Ler dois valores inteiros para as variáveis A e B e efetuar a troca dos valores de forma que a variável A passe a possuir o valor da variável B e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.
            //Declaração de Variáveis
            int A, B, Z;
            //Dados de Entrada
            Console.WriteLine("Digite um valor inicial para A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor inicial para B: ");
            B = int.Parse(Console.ReadLine());
            //Processamento
            Z = A;
            A = B;
            B = Z;
            //Saída de Dados
            Console.WriteLine("O valor final de A é " + B);
            Console.WriteLine("O valor final de B é " + A);

            Console.ReadKey();

            //8-Efetuar a leitura de um número inteiro e apresentar o resultado do quadrado desse número.
            //Declaração de Variáveis
            int N3,N4;
            //Dados de Entrada
            Console.Write("Digite um valor para obter como resultado seu quadrado: ");
            N3 = int.Parse(Console.ReadLine());
            //Processamento
            N4 = N3 * N3;
            //Saída de Dados
            Console.WriteLine("O quadrado é igual a: "+N4);

            Console.ReadKey();

            //9-Faça um algoritmo que leia a idade de uma pessoa expressa em dias e mostre-a expressa em anos, meses e dias.
            //Declaração de Variáveis
            int Id,IdAnos, IdMeses, IdDias;
            //Dados de Entrada
            Console.Write("Cálculo da idade em anos, meses e dias.");
            Console.Write("Digite a idade em dias: ");
            Id = int.Parse(Console.ReadLine());
            //Processamento
            IdAnos = Id / 365;
            IdMeses = Id % 365 / 30;
            IdDias = (Id % 365) % 30 ;
            //Saída de Dados
            Console.WriteLine("A idade é "+IdAnos+" Anos ,"+IdMeses+" meses e "+IdDias+" dias.");

            Console.ReadKey();

             //10-Faça um algoritmo que leia a idade de uma pessoa expressa em ano, mês e dia e mostre-as em dias.
            //Declaração de Variáveis
            int Id1, IdAnos1, IdMeses1, IdDias1;
            //Dados de Entrada
            Console.WriteLine("Cálculo da Idade em Dias.");
            Console.WriteLine("Digite a Idade em anos");
            IdAnos1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Idada em meses");
            IdMeses1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Idade em dias");
            IdDias1 = int.Parse(Console.ReadLine());
            //Processamento
            Id1 = (IdAnos1*365 + IdMeses1*30 + IdDias1);
            //Saída de Dados
            Console.WriteLine("A idade em total de dias é "+Id1);

            Console.ReadKey();

            //11-Faça um programa que calcule a área da circunferência.
            //Declaração de Variáveis
            float PI1 = 3.14159f;
            float r, P;
            //Entrada de Dados
            Console.WriteLine("Digite o valor do raio da circunferencia em cm: ");
            r = float.Parse(Console.ReadLine());
            //Processamento
            P = PI1 * (r * r);
            //Saída de Dados
            Console.WriteLine("A área da circunferencia em cm é igual a "+P);

            //12-Faça um programa que receba um número e mostre o resto da divisão por 6
            //Declaração de Variáveis
            int N5, r1;
            //Entrada de Dados
            Console.WriteLine("Cálculo da divisão de um número inteiro por 6");
            Console.WriteLine("Digite um número");
            N5 = int.Parse(Console.ReadLine());
            //Processamento
            r1 = N5 % 6;
            //Saída de Dados
            Console.WriteLine("O resto da divisão do número escolhido por 6 é "+r1);

            Console.ReadLine();

            //13-Elaborar um programa que efetue a apresentação do valor da conversão em real de um valor lido em 
            //dólar. O programa deve solicitar o valor da cotação do dólar e também a quantidade de dólares disponível
            //com o usuário, para que seja apresentado o valor em moeda brasileira.
            //Declaração de Variáveis
            float Cot, R0;
            int Qtde;
            //Entrada de Dados
            Console.WriteLine("Conversão Dólar em Real.");
            Console.WriteLine("Digite a quantidade de dólares para a conversão: ");
            Qtde = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor da Cotação do Dólar do dia: ");
            Console.WriteLine("Cotação: Valor do dólar equivalente a 1 real.");
            Cot = float.Parse(Console.ReadLine());
            //Processamento
            R0 = Qtde * Cot;
            //Saída de Dados
            Console.WriteLine(+Qtde+" dólares equivalem a "+R0+" reais na cotação atual.");

            Console.ReadKey();         

        }
    }
}
