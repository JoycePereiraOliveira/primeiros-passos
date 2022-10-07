using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduloVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercício - Valores Liteirais
            // Armazenar e recuperar dados usando valores literais e variáveis em C#

            // Etapa 1: Gravar um literal char no console

            // O tipo de dados String é usado sempre que você tem palavras alfanuméricas, frases ou dados para apresentação;
            // Um único caractere alfanúmerico impresso na tela, literal char: aspas simples;
            // O termo: char é a abreviação de caractere em inglês, denominação oficial "char", frequentemente chamados de "caractere";
            // Console.WriteLine('b');

            // Console.WriteLine('Hello World!');
            // (12,20): error CS1012: Too many characters in character literal

            //---------------------------------------------------------------------------------------------------------------------------

            // Etapa 2 - Gravar um literal int no console
            // O termo: int é a abreviação de inteiro, denominação oficial "int", frequentemente chamados de "inteiro";
            //Console.WriteLine(123);

            //---------------------------------------------------------------------------------------------------------------------------

            // Etapa 3: Gravar um literal decimal no console

            // Literal decimal: acrescente a letra "m" após o número. Nesse contexto, o "m" é chamado de sufixo literal;
            // Console.WriteLine(12.30m);

            //---------------------------------------------------------------------------------------------------------------------------

            // Etapa 4: Gravar um literal bool no console
            // Imprimir valor representando "true" ou "false": literal bool;
            // Console.WriteLine(true);
            // Console.WriteLine(false);
            //-------------------------------------------------------------
            // Console.WriteLine("123"); - string;
            // Console.WriteLine(123); - int;

            // Console.WriteLine("true") - string;
            // Console.WriteLine(true) - bool;

            // string: para palavras, frases ou qualquer dado alfanumérico para apresentação, não cálculo;
            // char: para um caractere alfanumérico;
            // int: para um número inteiro;
            // decimal: para um número com um decimal;
            // bool: para um valor true/false

            //---------------------------------------------------------------------------------------------------------------------------

            // Etapa 5: Declarar Variáveis

            // Variável: item de dados que pode alterar seu valor durante seu tempo de vida;
            // Declarar o tipo de dados da variável e dar um nome a ela;
            // Variáveis são valores temporários que você armazena na memória do computador;
            // string firstName;

            // Exercício: configurar e obter valores de variáveis;
            // Atribuir um valor: "definir a variável" ou uma operação "set";
            //string firstName;
            //firstName = "Bob";
            //-------------------------------------------------------------
            // string firstName;
            // "Bob" = firstName;
            // (62,1): error CS0131: The left-hand side of an assignment must be a variable, property or indexer
            //-------------------------------------------------------------
            // int firstName;
            // firstName = "Bob";
            // (66,13): error CS0029: Cannot implicitly convert type 'string' to 'int'
            //-------------------------------------------------------------
            // Recuperar um valor: "obter a variável" ou uma operação "get";
            // string firstName;
            // firstName = "Bob";
            // Console.WriteLine(firstName);
            //-------------------------------------------------------------
            // string firstName;
            // firstName = "Bob";
            // Console.WriteLine(firstName);
            // firstName = "Beth";
            // Console.WriteLine(firstName);
            // firstName = "Conrad";
            // Console.WriteLine(firstName);
            // firstName = "Grant";
            // Console.WriteLine(firstName);
            //-------------------------------------------------------------
            // string firstName;
            // Console.WriteLine(firstName);
            // (85,19): error CS0165: Use of unassigned local variable 'firstName'
            //-------------------------------------------------------------
            // Declarar e definir o valor da variável em uma linha de código: inicializar a variável;
            // string firstName = "Bob";
            // Console.WriteLine(firstName);

            //---------------------------------------------------------------------------------------------------------------------------

            // Variável local de tipo implícito é criada usando a palavra-chave: var, instrui o compilador a inferir o tipo com...
            // ... base no valor para o qual ele é inicializado;
            // var message = "Hello World!";

            // var message = "Hellor World!";
            // message = 10.0m;
            // (98,11): error CS0029: Cannot implicitly convert type 'decimal' to 'string'

            // var message;
            // (101,5): error CS0818: Implicitly-typed variables must be initialized
            // (101,5): error CS0168: The variable 'message' is declared but never used
            // Você provavelmente verá a palavra-chave var enquanto lê o código de outras pessoas...
            // ... No entanto, você deve usar o tipo de dados quando possível.

            //---------------------------------------------------------------------------------------------------------------------------

            // Desafio 02 - escrever o código no Editor do .NET para exibir uma mensagem:

            string name = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;
            Console.WriteLine("Hello, " + name + "! You have a " + messages + " messages in your inbox. The temperature is " + temperature + " celsius.");

            // Possível solução C#:

            // string name = "Bob";
            // int messages = 3;
            // decimal temperature = 34.4m;

            // Console.Write("Hello, ");
            // Console.Write(name);
            // Console.Write("! You have ");
            // Console.Write(messages);
            // Console.Write(" messages in your inbox. The temperature is ");
            // Console.Write(temperature);
            // Console.Write(" celsius.");

        }
    }
}
