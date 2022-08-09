// Instruções de uma única linha
// No C#, um bloco de instrução é sempre escrito entre chaves {} para delimitar seu contexto. Porém, o uso das chaves não é obrigatório para definir uma instrução de uma linha como ocorre em: for, foreach e while.

// Veja os exemplos a seguir:


for (int count = 0; count < 10; count++)
    Console.WriteLine(count);

int[] numbers = new int[] { 1, 2, 3, 4 };
var sum = 0;
foreach (var number in numbers)
    sum += number;

var isClosed = false;
while (!isClosed)
    isClosed = CloseConnection();