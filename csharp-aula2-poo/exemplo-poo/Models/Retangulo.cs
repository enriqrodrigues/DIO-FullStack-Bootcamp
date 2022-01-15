namespace exemplo_poo.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void definirMedidas(double comprimento, double largura)
        {
            if(comprimento > 0 && largura > 0){
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            } else {
                System.Console.WriteLine("Valores Imválidos!"); //Dica de atalho: Digite cw e aperte Tab.
            }
        }

        public double calcArea()
        {
            if(valido){
                return comprimento * largura;
            } else {
                System.Console.WriteLine("Preencha corretamente!"); 
                return 0;
            }
        }
    }
}