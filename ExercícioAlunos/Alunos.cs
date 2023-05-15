namespace ExercícioAlunos;
class Alunos
{
    public string nome="";

    public double nota1,nota2;

    public double obterMedia(){
        double media = (nota1+nota2)/2;
        return media;
    }

    public string obterSituação(double media){
        string situacao ="";
        if (media>=6){
            situacao = "Aprovado";
        }
        else{
            situacao = "Reprovado";
        }
        return situacao;

    }
    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao = obterSituação(mediaCalculada);
        Console.WriteLine(nome + " está "+ resultadoSituacao + " com a média " + mediaCalculada);
    }
}

//MÉDIA - retorna um double - exemplo: um número 8.3
//SITUAÇÃO DO ALUNO- retorna um string(caractere) "apovado" ou "reprovado"
//MENSAGEM - não retorna nada. Apenas mostra na tela os detalhes como: media, nome e situação