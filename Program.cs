using System;

namespace bank_acc_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco cliente1 = new ContaBanco();
            cliente1.NumConta = 1111;
            cliente1.Dono = "Jubileu";
            cliente1.abrirConta("CC");
            cliente1.depositar(200);
            cliente1.sacar(250);
            cliente1.fecharConta();
            cliente1.estadoAtual();

            ContaBanco cliente2 = new ContaBanco();
            cliente2.NumConta = 2222;
            cliente2.Dono = "Creuza";
            cliente2.abrirConta("CP");
            cliente2.depositar(500.50);
            cliente2.sacar(150);
            cliente2.estadoAtual();
            
        }
    }
}
