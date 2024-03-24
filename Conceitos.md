## Namespace

Local onde as classes do .NET Framework estão localizadas

System. Console .WriteLine("Hello World!");
|--namespace--|--Classe--|-----------Método----------|

Quando usamos a palavra chave "using" estamos dizendo que queremos utilizar as classes dentro do namespace e não precisamos colocar o Namespace.Classe, somente a Classe. Exemplo: 
    using System;
    using System.Collections.Generic;
    using System.IO;

## Classes
    Todos os programas em C# terão 1:N Classes
    - Uma classe deve concentrar todo o código responsável por resolver os problemas para os quais ela foi criada.
• Ex.: class Cadastro - responsável pelo cadastro, mas não pela transferência entre contas. (SoC – Separation of Concerns)

## Static
-  Palavra chave que permite a chamada do método ou propriedade sem necessidade de Instância da Classe.

## Void 
- Indica que este método não terá nenhum retorno de nosso interesse.

## Main
- Onde começa o programa

# Strings, Arrays, IO

## Strings
- Classe que representam Texto

## Concatenar

método "normal"
string str1 = "Olá, ";
string str2 = "mundo!";
string concatenada = str1 + str2;
Console.WriteLine(concatenada); // Saída: "Olá, mundo!"

## Split
Dividir uma string em substrings com base em um ou mais caracteres delimitadores.

string texto = "Maçã, Banana, Uva, Laranja";
string[] partes = texto.Split(',');

foreach (string parte in partes)
{
    Console.WriteLine(parte.Trim()); // Trim() remove os espaços em branco ao redor de cada parte
}

Neste exemplo, a string "Maçã, Banana, Uva, Laranja" é dividida em substrings usando a vírgula como delimitador. O método Split() retorna um array de strings contendo as partes divididas. O foreach é usado para iterar sobre as partes divididas e exibi-las no console.

------ 

string texto = “Rua abc, 35, Marília, São Paulo";
string[] teste = texto.Split(',');
string[] teste = texto.Split(null);
*colocando null, o split assume que a separação é através de
espaços

## Substring

public string Substring (int startIndex);

- Quebrar textos a partir de uma posição
- Zero based (começa a contar de zero)
- Quantidade de caracteres a serem pegos

## IndexOf

public int IndexOf (string value, int startIndex, int count);

- Busca determinado caracter dentro do texto
Zero based (começa a contar de zero)
- Retorna a posição do caracter encontrado
- Retorna -1 caso não encontre
- É Case Sensitive N <> n

## StringBuilder
- Constrói um texto a partir de outros - Utilizado no lugar de Strings quando estes sofrem várias mudanças (Append, Insert, Remove)

    StringBuilder stringBuilder = new StringBuilder("Texto Inicial");

    stringBuilder.Append(" Outro texto 1");
    Console.WriteLine(stringBuilder);
    stringBuilder.Insert(0, "texto 2 ");
    Console.WriteLine(stringBuilder);
    stringBuilder.Remove(0, 8);
    Console.WriteLine(stringBuilder);

## Replace 
    public string Replace (char oldChar, char newChar);

## Trim
Remove todos os caracteres de espaço em branco à esquerda e à direita da cadeia de caracteres atual.
    public string Trim ();

## Length
Obtém o número de caracteres no objeto String atual.    
    public int Length { get; }

## ToLower ou Upper
    public string ToLower ();







