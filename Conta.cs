public class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set; }
   public Conta(int codigo)
   {

       Codigo = codigo;
       Saldo = 0.0;

   }

   public void Sacar(double valor)
   {

       ValidarValor(valor);
       ValidarSaldo(valor);
       Saldo = Saldo - valor;

   }

   public void Depositar(double valor)
   {

       ValidarValor(valor);
       Saldo = Saldo + valor;

   }

   public void Transferir(double valor, Conta conta)
   {

       /*
       ValidarValor(valor);
       ValidarSaldo(valor);
       Saldo = Saldo - valor;
       conta.Saldo = conta.Saldo + valor;
       */

       Sacar(valor);
       conta.Depositar(valor);

   }

   private void ValidarValor(double valor)
   {

       if(valor<=0)
           throw new ArgumentException("O valor deve ser maior que 0");

   }

   private void ValidarSaldo(double valor)
   {

       if(valor > Saldo)
           throw new ArgumentException("O saldo da conta não é suficiente");

   }

}