
namespace Milho
{
   public class Gerenciador{

    List<Questao> listaQuestoes = new List<Questao>();
    List<int> listaQuestaoRespondida = new List<int>();
    Questao questaoAtual;
    public Gerenciador(Label labelPergunta, Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        CriarQuestoes(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
    }

    void CriarQuestoes(Label labelPergunta, Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        var q1 = new Questao();

        q1.Pergunta = "qual foi a linguagem de programação q levou o homen a lua ";
        q1.Resposta1 = "JAVA";
        q1.Resposta2 = "SQL";
        q1.Resposta3 = "python"; 
        q1.Resposta4 = "assembly";
        q1.Resposta5 = "mais ele nem foi a lua mano";

        q1.RespostaCerta = 4;
        q1.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q1);

        var q2 = new Questao();
        q2.Pergunta = "Qual a linguagem de programação foi criada em 1998";
        q2.Resposta1 = "C#";
        q2.Resposta2 = "HTML";
        q2.Resposta3 = "kotlin";
        q2.Resposta4 = "C++";
        q2.Resposta5 = "C";

        var q3 = new Questao();
        q3.Pergunta = "O que é DOTNET.newMAUI";
        q3.Resposta1 = "framework";
        q3.Resposta2 = "linguagem de programação";
        q3.Resposta3 = "nenhum desses";
        q3.Resposta4 = "Biblioteca";
        q3.Resposta5 = "IDE";

        q3.RespostaCerta = 1;
        q3.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q3);

        var q4 = new Questao();
        q4.Pergunta = "Quando o foi o vazamento de dados da microsoft";
        q4.Resposta1 = "2024";
        q4.Resposta2 = "2000";
        q4.Resposta3 = "2006";
        q4.Resposta4 = "Saturno";
        q4.Resposta5 = "Netuno";

        q4.RespostaCerta = 3;
        q4.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q4);

        var q5 = new Questao();
        q5.Pergunta = "Quem foi arthur mamãe falei";
        q5.Resposta1 = "Machado de Assis";
        q5.Resposta2 = "1 poeta";
        q5.Resposta3 = "youtuber";
        q5.Resposta4 = "cara aleatorio";
        q5.Resposta5 = "Graciliano Ramos";

        q5.RespostaCerta = 2;
        q5.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q5);

        var q6 = new Questao();
        q6.Pergunta = "Quantos continentes existem?";
        q6.Resposta1 = "5";
        q6.Resposta2 = "6";
        q6.Resposta3 = "7";
        q6.Resposta4 = "4";
        q6.Resposta5 = "8";

        q6.RespostaCerta = 3;
        q6.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q6);

        var q7 = new Questao();
        q7.Pergunta = "Qual é a fórmula da água?";
        q7.Resposta1 = "H2O";
        q7.Resposta2 = "O2";
        q7.Resposta3 = "CO2";
        q7.Resposta4 = "NaCl";
        q7.Resposta5 = "C6H12O6";

        q7.RespostaCerta = 1;
        q7.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q7);

        var q8 = new Questao();
        q8.Pergunta = "Qual é a língua mais falada do mundo?";
        q8.Resposta1 = "Inglês";
        q8.Resposta2 = "Mandarim";
        q8.Resposta3 = "Espanhol";
        q8.Resposta4 = "Francês";
        q8.Resposta5 = "Árabe";

        q8.RespostaCerta = 2;
        q8.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q8);

        var q9 = new Questao();
        q9.Pergunta = "Quem pintou a Mona Lisa?";
        q9.Resposta1 = "Vincent van Gogh";
        q9.Resposta2 = "Leonardo da Vinci";
        q9.Resposta3 = "Pablo Picasso";
        q9.Resposta4 = "Claude Monet";
        q9.Resposta5 = "Michelangelo";

        q9.RespostaCerta = 2;
        q9.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q9);

        var q10 = new Questao();
        q10.Pergunta = "O que é if e else?";
        q10.Resposta1 = "se e se não";
        q10.Resposta2 = "se não e se sim";
        q10.Resposta3 = "loop laço de repetição";
        q10.Resposta4 = "while";
        q10.Resposta5 = "Oceano Antártico";

        q10.RespostaCerta = 1;
        q10.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q10);

        var q11 = new Questao();
        q11.Pergunta = "Qual é o comando usado para criar tabela e banco de dados no SQL?";
        q11.Resposta1 = "CREATE TABLE CLIENTE()";
        q11.Resposta2 = "DROP CLIENTE";
        q11.Resposta3 = "DELETE FROM CLIENTE";
        q11.Resposta4 = "CREATE VIEW CLIENTE";
        q11.Resposta5 = "AS CLIENTE";

        q11.RespostaCerta = 1;
        q11.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q11);

        var q12 = new Questao();
        q12.Pergunta = "O que significa a sgla SGBD";
        q12.Resposta1 = "Sistema de gerenciamento de dados";
        q12.Resposta2 = "Sistema de segurança de dados";
        q12.Resposta3 = "Sistema de gerenciamento e monitoramento";
        q12.Resposta4 = "Sistema sigilo de dados";
        q12.Resposta5 = "nenhuma delas";

        q12.RespostaCerta = 1;
        q12.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q12);

        var q13 = new Questao();
        q13.Pergunta = "O que é back-end";
        q13.Resposta1 = "cara que cuida de baixo dos panos de 1 site";
        q13.Resposta2 = "cara que cuida da interface do site";
        q13.Resposta3 = "é o cara que cuida dos dados";
        q13.Resposta4 = "é o patrão";
        q13.Resposta5 = "é 1 CLT aí";

        q13.RespostaCerta = 1;
        q13.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q13);

        var q14 = new Questao();
        q14.Pergunta = "Qual é a 1 linguagem de programação criada";
        q14.Resposta1 = "Fortran";
        q14.Resposta2 = "Binario";
        q14.Resposta3 = "JAVA";
        q14.Resposta4 = "HTML";
        q14.Resposta5 = "CSS";

        q14.RespostaCerta = 1;
        q14.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q14);

        var q15 = new Questao();
        q15.Pergunta = "Quem é o criador do COBOL linguagem de programação'?";
        q15.Resposta1 = "Lucas Mathias Belini";
        q15.Resposta2 = "Grace Murray Hopper";
        q15.Resposta3 = "Anders hejlsberg";
        q15.Resposta4 = "James Gosling";
        q15.Resposta5 = "Brendan Eich";

        q15.RespostaCerta = 2;
        q15.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q15);

        var q16 = new Questao();
        q16.Pergunta = "Qual planeta é conhecido como o 'planeta vermelho'?";
        q16.Resposta1 = "Marte";
        q16.Resposta2 = "Vênus";
        q16.Resposta3 = "Júpiter";
        q16.Resposta4 = "Saturno";
        q16.Resposta5 = "Mercúrio";

    }
       public void ProximaQuestao()
{
    var numRandom = Random.Shared.Next(0, listaQuestoes.Count);

    while (listaQuestaoRespondida.Contains(numRandom))
    {
        numRandom = Random.Shared.Next(0, listaQuestoes.Count);
    }

    listaQuestaoRespondida.Add(numRandom);
    questaoAtual = listaQuestoes[numRandom];
    questaoAtual.Desenhar();
}

public async void VerificaCorreta(int RespostaSelecionada)
{
    if (questaoAtual.VerificaResposta(RespostaSelecionada))
    {
        await Task.Delay(1000);
        ProximaQuestao();
    }
}

   
       }
}



      