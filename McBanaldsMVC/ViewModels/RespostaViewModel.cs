namespace McBanaldsMVC.ViewModels
{
    public class RespostaViewModel
    {
        public string Menssagem {get;set;}

        public RespostaViewModel()
        {

        }

        public RespostaViewModel(string menssagem)
        {
            this.Menssagem = menssagem;
        }
    }
}