// Instrução break
// A instrução break, como o próprio nome já diz, é utilizada para interromper a
//  execução de um laço de repetição (for, foreach, do\while e while). Veja como funciona no exemplo a seguir:

string[] teachers = new string[] { "Joel", "Tess", "Marlene" };
string[] students = new string[] { "Ellie", "Joel", "Abby" };
foreach (var teacher in teachers)
{
    Console.WriteLine("Professor: " + teacher + ". Estudante:");
    foreach (var student in students)
    {               
        if (teacher == student)
            break;
        Console.WriteLine(student);
    }
}  