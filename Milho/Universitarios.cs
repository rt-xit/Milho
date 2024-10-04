namespace Milho;
public class Universitarios : IAjuda
{

    public override void RealizaAjuda(Questao questao)
    {
        var porcentagem = 100;
        for (int i = 0; i < 5; i++)
        {
            int numRand = 0;
            if (porcentagem > 0)
            {
                numRand = Random.Shared.Next(0, porcentagem);
                porcentagem -= numRand;

                switch (i)
                {
                    case 0:
                        BtnResp01.Text += "-" + numRand.ToString() + "%";
                        break;

                    case 1:
                        BtnResp02.Text += "-" + numRand.ToString() + "%";
                        break;

                    case 2:
                        BtnResp03.Text += "-" + numRand.ToString() + "%";
                        break;

                    case 3:
                        BtnResp04.Text += "-" + numRand.ToString() + "%";
                        break;

                    case 4:
                        BtnResp05.Text += "-" + numRand.ToString() + "%";
                        break;
                }
            }
        }
    }
}