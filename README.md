# bibCSharp
Como fazer coisas em C#

## Tipos de dados 
    int: Armazena números inteiros.
    double: Armazena números de ponto flutuante de dupla precisão.
    string: Armazena sequências de caracteres.
    char: Armazena um único caractere.
    bool: Armazena valores booleanos (verdadeiro ou falso).
    decimal: Usado para números de ponto flutuante de alta precisão.
    DateTime: Armazena datas e horas.

## Converter tipos
    - Convert -> classe responsável por Converter Tipos
    - .ToDouble -> Método da classe Convert para conversão para Double, para int, etc


## Printar
    
    - Console.Write() // Escreve o texto na mesma linha

    (Console.Write("Olá ");
    Console.Write("Mundo");
    
    Olá Mundo)

   - Console.WriteLine() //Escreve o texto e logo a seguir quebra para a linha seguinte por exemplo:

    (Console.WriteLine("Olá ");
    Console.WriteLine("Mundo");

    Olá
    Mundo)

## Input
    Console.ReadLine();



## Random
 - Crie uma instância da classe Random
    Random random = new Random();
 - Gerar um número inteiro aleatório entre 0 e 100 (exclusivo)
    int numeroAleatorio = random.Next(0, 100);


## Ler arquivos
 - Setar caminho do arquivo
    StreamReader sr = new StreamReader("C:\\Sample.txt");
- Ler a primeira linha do arquivo
    line = sr.ReadLine();
- Continua a ler até a última linha
    while (line != null)
    {
        //write the line to console window
        Console.WriteLine(line);
        //Read the next line
        line = sr.ReadLine();
    }


