using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduloFormatacaoChar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercício - Sequências de escape de caractere e cadeias de caracteres textuais

            // Sequência de caracteres de escape começam com uma barra invertida: \;
            // Sequência \n adicionará uma nova linha;
            // Sequência: \t adicionará uma guia;

            // Console.WriteLine("Hello\nWorld!");
            // Console.WriteLine("Hello\tWorld!");
            /* 
                Hello
                World!
                Hello	World!
            */

            //---------------------------------------------------------------------------------------------------------------------------

            // Aspas dupla em uma cadeia de caracteres literal;
            // Se não usar a sequência de caractere de escape, você confundirá o compilador porque ele achará que você deseja terminar...
            //... a cadeia de caracteres prematuramente, e não entenderá a finalidade dos caracteres após a segunda aspa dupla;

            // Console.WriteLine("Hello "World"!");
            /*
                (20,27): error CS1003: Syntax error, ',' expected
                (20,27): error CS0103: The name 'World' does not exist in the current context
                (20,32): error CS1003: Syntax error, ',' expected
            */
            //-------------------------------------------------------------------------
            // Console.WriteLine("Hello \"World\"!");
            /*
                Hello "World"!
            */

            //---------------------------------------------------------------------------------------------------------------------------

            // Barra invertida para outras finalidades: exibir um caminho de arquivo:

            //  Console.WriteLine("c:\source\repos");
            /*
                (41,22): error CS1009: Unrecognized escape sequence
            */
            //-------------------------------------------------------------------------
            // O problema é a sequência \s. A \r não produz um erro porque é uma sequência de escape válida para um retorno de carro;

            // Console.WriteLine("c:\\source\\repos");
            /*
                c:\source\repos
            */

            //---------------------------------------------------------------------------------------------------------------------------

            // Etapa 1 - Formatar a saída do aplicativo de linha de comando usando sequências de escape de caractere

            // Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            // Console.WriteLine("Invoice: 1021\t\tComplete!");
            // Console.WriteLine("Invoice: 1022\t\tComplete!");
            // Console.WriteLine("\nOutput Directory:\t");

            /*
                Generating invoices for customer "ABC Corp" ...

                Invoice: 1021		Complete!
                Invoice: 1022		Complete!

                Output Directory:	
            */

            //---------------------------------------------------------------------------------------------------------------------------

            // Um literal de cadeia de caracteres textual manterá todo o espaço em branco...
            // ... e os caracteres sem a necessidade de escapar da barra invertida...
            // Para criar uma cadeia de caracteres textual, use a diretiva @ antes da cadeia de caracteres literal. Dois caracteres de aspas...
            // ... duplas consecutivas ("") são impressos como um único caractere de aspas duplas (") na cadeia de caracteres de saída;

            // Console.WriteLine(@"    c:\source\repos
            //         ("" this is were your code goes "")");
            /*
                    c:\source\repos
                    (" this is were your code goes ")
            */

            //---------------------------------------------------------------------------------------------------------------------------

            // Etapa 2: Formatar a saída do aplicativo de linha de comando usando uma cadeia de caracteres textual

            // Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            // Console.WriteLine("Invoice: 1021\t\tComplete!");
            // Console.WriteLine("Invoice: 1022\t\tComplete!");
            // Console.WriteLine("\nOutput Directory:\t");
            // Console.WriteLine(@"c:\invoices");
            /*
                Generating invoices for customer "ABC Corp" ...

                Invoice: 1021		Complete!
                Invoice: 1022		Complete!

                Output Directory:	
                c:\invoices
            */

            //---------------------------------------------------------------------------------------------------------------------------

            // Adicionar caracteres codificados em cadeias de caracteres literais usando a sequência de escape: \n...
            // ... e, em seguida, um código de quatro caracteres representando algum caractere em Unicode (UTF-16);

            // Kon'nichiwa World
            // Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            /*
                こんにちは World!
            */

            //---------------------------------------------------------------------------------------------------------------------------

            // Etapa 3: Formatar a saída do aplicativo de linha de comando usando caractere de escape Unicode

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            // Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // Console.WriteLine(@"c:\invoices\app.exe -j");
            /*
                日本の請求書を生成するには：
                c:\invoices\app.exe -j
            */
            //-------------------------------------------------------------------------
            // Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            // Console.WriteLine("Invoice: 1021\t\tComplete!");
            // Console.WriteLine("Invoice: 1022\t\tComplete!");
            // Console.WriteLine("\nOutput Directory:\t");
            // Console.Write(@"c:\invoices");

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            // Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // Console.WriteLine(@"c:\invoices\app.exe -j");
            /*
                Generating invoices for customer "ABC Corp" ...

                Invoice: 1021		Complete!
                Invoice: 1022		Complete!

                Output Directory:	
                c:\invoices

                日本の請求書を生成するには：
                    c:\invoices\app.exe -j
            */

            // Use as sequências de escape de caractere quando precisar inserir um caractere especial em uma cadeia de caracteres literal...
            // ... como uma tabulação \t, uma nova linha \n ou uma aspa dupla \";
            // Use um caractere de escape para a barra invertida \\ quando precisar usar uma barra invertida em todos os outros cenários;
            // Use a diretiva @ para criar um literal de cadeia de caracteres que mantenha toda a formatação de espaço em branco...
            // ... e caracteres de barra invertida em uma cadeia de caracteres;
            // Use o \u mais um código de quatro caracteres para representar caracteres Unicode (UTF-16) em uma cadeia de caracteres;
            // Os caracteres Unicode podem não ser impressos corretamente dependendo do aplicativo;

            //---------------------------------------------------------------------------------------------------------------------------

            // Exercício - Concatenação de cadeias de caracteres

            // Etapa 1: Concatenar uma cadeia de caracteres literal e uma variável
            // Concatenação de cadeia de caracteres: "fala do programador", combinar dois ou mais valores em um novo valor;
            // Operador de concatenação: símbolo de adição "+";

            // string firstName = "Bob";
            // string message = "Hello " + firstName;
            // Console.WriteLine(message);
            /*
                Hello Bob
            */
            //-------------------------------------------------------------------------
            // Etapa 2: Concatenar diversas variáveis e cadeias de caracteres literais

            // string firstName = "Bob";
            // string greeting = "Hello";
            // string message = greeting + " " + firstName + "!";
            // Console.WriteLine(message);
            /*
                Hello Bob!
            */
            //-------------------------------------------------------------------------
            // Etapa 3: Como evitar variáveis intermediárias

            // Evitar usar variáveis intermediárias executando a operação de concatenção;
            // Simplificando o código;

            // string firstName = "Bob";
            // string greeting = "Hello";
            // Console.WriteLine(greeting + " " + firstName + "!");
            /*
                Hello Bob!
            */

            //---------------------------------------------------------------------------------------------------------------------------

            // Exercício – Interpolação de cadeia de caracteres

            // Interpolação de cadeia de caracteres: combina vários valores em uma única cadeia de caracteres literal...
            // ... usando um "modelo" e uma ou mais expressões de interpolação;
            // Expressão de interpolação: variável cercada por um símbolo de chave de abertura e fechamento { };
            // Cadeia de caracteres: se torna um modelo quando ele é prefixado pelo caractere $;

            // string message = greeting + " " + firstName + "!";

            // string message = $"{greeting} {firstName}!";
            //-------------------------------------------------------------------------
            // Etapa 1: usar a interpolação de cadeia de caracteres para combinar uma cadeia de caracteres literal e um valor variável

            // string firstName = "Bob";
            // string message = $"Hello {firstName}!";
            // Console.WriteLine(message);
            /*
                Hello Bob!
            */
            //-------------------------------------------------------------------------
            // Etapa 2: usar a interpolação de cadeia de caracteres com diversas cadeias de caracteres literais e variáveis

            // string firstName = "Bob";
            // string greeting = "Hello";
            // string message = $"{greeting} {firstName}!";
            // Console.WriteLine(message);
            /*
                Hello Bob!
            */
            //-------------------------------------------------------------------------
            // Etapa 3: evitar variáveis intermediárias

            // string firstName = "Bob";
            // string greeting = "Hello";
            // Console.WriteLine($"{greeting} {firstName}!");
            /*
                Hello Bob!
            */
            //-------------------------------------------------------------------------
            // Etapa 4: combinar literais textuais e interpolação de cadeia de caracteres

            // Usar um literal textual em seu modelo: usar o símbolo @ de prefixo literal textual e o símbolo $ de interpolação...
            // ... de cadeia de caracteres juntos;

            // string projectName = "First-Project";
            // Console.WriteLine($@"C:\Output\{projectName}\Data");
            /*
                C:\Output\First-Project\Data
            */
            // A interpolação de cadeia de caracteres fornece uma melhoria na concatenação de cadeia de caracteres...
            // ... reduzindo o número de caracteres necessários em algumas situações;

            //---------------------------------------------------------------------------------------------------------------------------

            // Desafio 03 - Imprimir instruções para o usuário final para que ele saiba onde seu aplicativo gerará arquivos de dados

            // Solução:

            string projectName = "ACME";
            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

        }
    }
}
