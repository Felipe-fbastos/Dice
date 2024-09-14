namespace DiceRoller;



public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

   

    public void RollButton_Clicked(object sender, EventArgs e)

    //Sortear um número aleatório através do clique do botão
    //Devolver o número sorteado para a interface
    //Conseguir selecionar a quantidade de lados a partir do Picker
    {

        /* int QuantidadeDeLados = Convert.ToInt32(SidesPicker.SelectedItem.ToString()); Converte a variável NúmeroSelecionado (int numeroSelecionado = Convert.ToInt32) para String. Dentro dos parênteses,
                                                                                      colocamos o X:nome de Picker para selecionar o picker.O Selected que guarda 
                                                                                      o valor inserido no picker*/


        /* Instaciamos o método Random (new Random().Next(). Dentro do parenteses 
                                                                      colocamos que o menor número a ser exibido que é 1 (), depois somamos +1 para chegar no total de lados */



        //ResultLabel.Text = numeroSorteado.ToString(); //A ResultLabel recebe o número sorteado e exbibe na  tela
      

       


        //ResultLabel.Text = $"{Sorteado} {numeroSorteado}";


        //int resul = Sorteado + numeroSorteado;

        
        
                int qtdeDados = int.Parse(Qtd_Entry.Text);
        /*
                        for(int i = 0; i < qtdeDados; i++)
                        {
                                int numeroDaQtd = Convert.ToInt32(SidesPicker.SelectedItem.ToString());

                                int modificador = Convert.ToInt32(QuantityPicker.SelectedItem.ToString());

                                int numeroDasorte = new Random().Next(1, numeroDaQtd * modificador) * qtdeDados ;

                                ResultLabel.Text = $"Resultado {numeroDasorte.ToString()} quantidade de dados rodados {qtdeDados}";

                        }
                */

        int soma = 0;

        for (int i = 0;i < qtdeDados; i++)
        {
            int QuantidadeDeLados = Convert.ToInt32(SidesPicker.SelectedItem.ToString());
            int numeroSorteado = new Random().Next(1, QuantidadeDeLados + 1);

            
            int Sorteado = new Random().Next(1, QuantidadeDeLados + 1);



             soma = (Sorteado + numeroSorteado) * qtdeDados;

            

            ResultLabel.Text = numeroSorteado.ToString(); 

            ResultadoLabel.Text = Sorteado.ToString();

           



        }

        Soma.Text = soma.ToString();


    }



    

}

