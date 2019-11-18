namespace McBonaldsMVC.Models
{
    public class Hamburguer : Produto
    {
        private double v;

        public Hamburguer()
        {

        }

        public Hamburguer(double v)
        {
            this.v = v;
        }

        public Hamburguer(string nome, double preco)
        {
            string nome1 = this.Nome;
            double preco1 = this.Preco;
        }
    }
}