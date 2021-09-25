using System;

namespace Banco
{
    class Program
    {
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
        }
        

        {

        {
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
        }
    }
}
