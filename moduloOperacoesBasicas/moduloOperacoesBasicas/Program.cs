using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduloOperacoesBasicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Módulo - Operações Básicas
            // Exercício - Adição simples e conversão de dados implícita

            // Etapa 1: Adicionar dois valores numéricos

            // Reutilização de um símbolo para várias finalidades: "sobrecarregar o operador";

            //  int firstNumber = 12;
            //  int secondNumber = 7;
            // Console.WriteLine(firstNumber + secondNumber);
            /*
                19
            */

            //---------------------------------------------------------------------------------------------------------------------------
            // Etapa 2: Adicionar código para executar a divisão usando dados decimais literais

            // decimal decimalQuotient = 7.0m / 5;
            // Console.WriteLine("Decimal quotient: " + decimalQuotient);
            /*
                Decimal quotient: 1.4
            */
            //--------------------------------------------------------------
            // Para que isso funcione, o quociente (à esquerda do operador de atribuição) deve ser do tipo decimale o dividendo ou o divisor...
            // ...deve ser do tipo decimal (ou ambos);
            // as seguintes linhas de código não funcionam (ou fornecem resultados imprecisos):
            // decimal decimalQuotient = 7 / 5.0m;
            // decimal decimalQuotient = 7.0m / 5.0m;
            //--------------------------------------------------------------
            // int decimalQuotient = 7 / 5.0m;
            // int decimalQuotient = 7.0m / 5;
            // int decimalQuotient = 7.0m / 5.0m;
            // decimal decimalQuotient = 7 / 5;

            //---------------------------------------------------------------------------------------------------------------------------

            // Etapa 3: Adicionar código para executar a divisão usando dados decimais literais

            // Para converter int para decimal, você adiciona o operador de conversão antes do valor. Você pode usar o nome do tipo de dados entre...
            // ...parênteses na frente do valor para convertê-lo. Neste caso, adicionaríamos (decimal) antes das variáveis first e second.

            // int first = 7;
            // int second = 5;
            // decimal quotient = (decimal)first / (decimal)second;
            // Console.WriteLine(quotient);
            /*
                1.4
            */

            //---------------------------------------------------------------------------------------------------------------------------

            // Etapa 4: Escrever código para determinar o resto após a divisão de int

            // Operador de resto %: informa o resto da divisão int;

            // Console.WriteLine("Modulus of 200 / 5 : " +(200 % 5));
            // Console.WriteLine("Modulus of 7 / 5 : " +(7 % 5));
            /*
                Modulus of 200 / 5 : 0
                Modulus of 7 / 5 : 2
            */

            // Quando o módulo é 0: dividendo divisível pelo divisor;
            // PEMDAS: 
            // Parênteses (o que estiver dentro do parêntese é executado primeiro);
            // Exponentes;
            // Multiplicação e Divisão (da esquerda para a direita);
            // Adição e Subtração (da esquerda para a direita);
            // O C# segue a mesma ordem que o acrônimo PEMDAS, exceto pelos exponentes. Embora não haja um operador com exponente em C#...
            // ...você pode usar o método System.Math.Pow();

            //---------------------------------------------------------------------------------------------------------------------------

            // Etapa 4: Escrever código para exercitar a ordem de operações em C#

            // int value1 = 3 + 4 * 5;
            // int value2 = (3 + 4) * 5;
            // Console.WriteLine(value1);
            // Console.WriteLine(value2);
            /*
                23
                35
            */
            // A ordem das operações seguirá as regras do acrônimo PEMDAS;

            //---------------------------------------------------------------------------------------------------------------------------

            // Exercício – Incrementar e decrementar valores

            // O operador += adiciona e atribui o valor à direita do operador ao valor à esquerda do operador;

            // int value = 0;
            // value = value + 5;
            // value += 5;
            // --------------------------------------------------------------
            // int value = 0;
            // value = value +1;
            // value++;

            // Essas técnicas podem ser usadas para subtração, multiplicação e mais;
            // --------------------------------------------------------------
            // int value = 1;

            // value = value + 1;
            // Console.WriteLine("First increment: " + value);

            // value += 1;
            // Console.WriteLine("Second increment: " + value);

            // value++;
            // Console.WriteLine("Third increment: " + value);

            // value = value - 1;
            // Console.WriteLine("First decrement: " + value);

            // value -= 1;
            // Console.WriteLine("Second decrement: " + value);

            // value--;
            // Console.WriteLine("Third decrement: " + value);
            /*
                First increment: 2
                Second increment: 3
                Third increment: 4
                First decrement: 3
                Second decrement: 2
                Third decrement: 1
            */
            // Se usar o operador antes do valor ++value: o incremento ocorrerá antes que o valor seja recuperado;
            // Se usar o opera depois do valor value++: incrementará o valor após ele ser recuperado;

            //---------------------------------------------------------------------------------------------------------------------------

            // Etapa 2: Usar o operador de incremento antes e depois do valor

            // int value = 1;
            // value++;
            // Console.WriteLine("First: " + value);
            // Console.WriteLine("Second: " + value++);
            // Console.WriteLine("Third: " + value);
            // Console.WriteLine("Fourth: " + (++value));
            /*
                First: 2
                Second: 2
                Third: 3
                Fourth: 4
            */
            // --------------------------------------------------------------

            // Use operadores de atribuição compostos como +=, -=, *=, ++ e -- para executar uma operação matemática como incremento ou decremento e...
            // ...em seguida, atribua o resultado à variável original;

            //---------------------------------------------------------------------------------------------------------------------------

            // Desafio 04 - Escreva o código no Editor do .NET para calcular os graus Celsius considerando a temperatura atual em Fahrenheit

            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5.0m / 9.0m);
            Console.WriteLine("The temperature is " + celsius + " Celsius.");

        }
    }
}
