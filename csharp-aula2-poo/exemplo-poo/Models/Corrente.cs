namespace exemplo_poo.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.Saldo = Saldo + valor;
            //Aqui nós podemos usar "this" ou "base". Normalmente usa-se "base" para apontar que estamos nos referindo à propriedade da classe pai.
        }
    }
}
