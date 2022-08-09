// Na declaração do foreach, temos a inicialização de uma variável do mesmo tipo da coleção, 
// o operador in, a coleção que o laço percorrerá e o bloco de instruções a ser executado. 
// A cada incremento do laço, um elemento da coleção será atribuído ao elemento inicalizado na 
// declaração e então o bloco de instruções será executado.

string[] names = new string[] { "Hulk", "Thor", "Loki" };
foreach (var name in names)
{
    Console.WriteLine(name);
}
// A leitura desse código é algo como: “execute o laço para cada name existente no array names“