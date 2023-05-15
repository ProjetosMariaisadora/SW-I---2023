namespace ExercícioAlunos;
class Program
{
    static void Main(string[] args)
    {
        Alunos alunos = new Alunos();
        alunos.nome = "Maria";
        alunos.nota1 = 5.0;
        alunos.nota2 = 8.0;

        alunos.mensagem();
    }
}
