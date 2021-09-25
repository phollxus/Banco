using System;

namespace Banco
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();

        static void Main(string[] args)
        {

        }
        private static string OpçãoUsuário()
        while (opçãoUsuário.ToUpper() != "X")
        { switch (opçãoUsuário)
        {
        Case "1";
            ContasCadastradas();
            break;
        Case "2";
            InserçãoDeContas();
            break;
        Case "3";
            Transferência();
            break;
        Case "4";
            Saque();
            break;
        Case "5";
            Empréstimo();
            break;
        Case "6";
            Depósito();
            break;
        Case "7";
            Voltar();
            break;
        Case "8";
            Sair();
            break;
        
        default: 
            throw new ArgumentOutOfRangeException();
        }
        opçãoUsuário = ObterOpçãoUsuário();
        Console.WriteLine("Agradecemos por utilizar nossos serviços!!!");
        Console.ReadLine();
         Console.WriteLine();
            Console.WriteLine("Banco Brasileiro a sua disposição!!!");
            Console.WriteLine("Informe a opção!!!");

            Console.WriteLine("1 - Contas cadastradas");
            Console.WriteLine("2 - Inserção de conta");
            Console.WriteLine("3 - Transferência");
            Console.WriteLine("4 - Saque");
            Console.WriteLine("5 - Empréstimo");
            Console.WriteLine("6 - Depósito");
            Console.WriteLine("7 - Voltar");
            Console.WriteLine("8 - Sair");
            Console.WriteLine();
            

            string OpçãoUsuário = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpçãoUsuário;

            private static void Saque {
                Console.Write("Digite o número da conta: ");
                int indiceConta = int.Parse(Console.ReadLine());
                
                Console.Write("Digite o valor a sacar: ");
                double valorSaque = double.Parse(Console.ReadLine());

                listContas[indiceConta].sacar(valorSaque);
                
            }
            private static void Transferência();
            {
                Console.Write("Digite a conta de origem: ");
                int indiceContaOrigem = int.Parse(Console.ReadLine());

                Console.Write("Digite o destinatário: ");
                int indiceDestinatário = int.Parse(Console.ReadLine());

                Console.write("Digite o valor transferido: ");
                double indiceValorTransferido = double.Parse(Console.ReadLine());

                listContas[indiceContaOrigem].Transferência(valorTransferência, listContas[indiceDestinatário]);

            }
            private static void Depósito();
            {
                Console.Write("Digite o número da conta: ");
                int indiceConta = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor do depósito:");
                double valorDepósito = double.Parse(Console.ReadLine());

                listContas[indiceConta].Depósito(valorDepósito);
            }



             private static void InserçãoDeContas();
        {
            Console.WriteLine(" Insira nova conta ");
            Console.WriteLine(" Digite 1 para pessoa física ou 2 para pessoa jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o nome do cliente: ");
            int entradaName = Console.ReadLine();

            Console.WriteLine(" Digite saldo inicial: ");
            int entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o crédito: ");
            int entradaCrédito = double.Parse(Console.ReadLine());

            Conta novaConta new Conta (tipoConta: (TipoConta)entradaTipoConta,
                                      saldo: entradaSaldo,
                                      crédito: entradaCrédito,
                                      Name: entradaName);

            listContas.Add(novaConta); 

            private static void ListarContas()
            {
            Console.WriteLine("Listar Contas");
            if (listContas.Count == 0)                         
}           {
    Console.WriteLine("Nenhum cadastro disponível!!!");
    return;
    for (int i = 0; i < listContas; i++)

    { 
        Conta conta = listContas(i);
        Console.Write("#{0} . ", i);
        Console.WriteLine(conta);
        
    }
}
        } 
        }
        

        {

        {
           
        }
       
    }
}
