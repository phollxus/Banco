namespace Banco.Conta
{
    public class Conta
    {
      private string Name { get; set; } 
      private TipoConta TipoConta { get; set; } 
      private double Saldo { get; set; }
      private double Crédito { get; set; }
       public Conta(string Name, TipoConta TipoConta, double Saldo, double Crédito )
    }
    this.Name = Name;
    this.TipoConta = TipoConta;
    this.Saldo = Saldo;
    this.Crédito = Crédito;
    public bool Saque(double valorSaque)
{
  if (this.Saldo - valorSaque < (this.Crédito *-1)) {
    Console.WriteLine("Recurso Indeferido");
    return false;
  }
  this.Saldo -= valorSaque
  Console.WriteLine( "Saldo da conta de {0} equivale a {1}", this.Name, this.Saldo );
  return true;
  
}
public void Depósito(double valorDepósito)
{
  this.Saldo += valorDepósito;
  Console.WriteLine( "Saldo de conta de {0} euivale a {1}", this.Name, this.Saldo );
  return true;
}
public void Transferência(double valorTransferência, Conta valorDestino)
{
 if (this.Saque(valorTransferência)) {
   contaDestino.Depósito(valorTransferência);
 }
 }
 public override string toString()
 {
   string retorno = "";
   retorno += "TipoConta " + this.TipoConta + " | ";
   retorno += "Name" + this.Name + " | ";
   retorno += "Saldo" + this.Saldo + " | ";
   retorno += "Crédito" + this.Crédito;
   return retorno;
 }  
}
