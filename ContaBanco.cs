using System;

namespace bank_acc_csharp
{
    public class ContaBanco
    {
        public int numConta;
        protected string tipo;
        private string dono;
        private double saldo;
        private bool status;

        public void estadoAtual()
        {
            Console.WriteLine("Conta: " + this.NumConta);
            Console.WriteLine("Tipo: " + this.Tipo);
            Console.WriteLine("Dono: " + this.Dono);
            Console.WriteLine("Saldo Total: " + this.Saldo);
            Console.WriteLine("Status: " + this.Status);
            Console.WriteLine("--------------------------");
        }

        public void abrirConta(string value)
        {
            this.Tipo = value;
            this.Status = true;
              if(value == "CC") 
            {
                this.Saldo = 50;
                Console.WriteLine("O cliente recebe " + Saldo + " ao abrir a conta.");
            } else if (value == "CP")
            {
                this.Saldo = 150;
                Console.WriteLine("O cliente recebe " + Saldo + " ao abrir a conta.");
            } 
            Console.WriteLine("Conta aberta com sucesso."); 
        }
        public void fecharConta()
        {
            if(this.Saldo > 0)
            {
                Console.WriteLine("A conta não pode ser fechada porque ainda tem " + Saldo + " reais.");
            } else if(this.Saldo < 0)
            {
                Console.WriteLine("A conta não pode ser fechada pois ainda tem débitos de " + Saldo + " reais.");
            } else
            {
                this.Status = false;
                Console.WriteLine("Conta fechada com sucesso.");
            }
        }
        public void depositar(double value)
        {
            if(this.Status)
            {
                this.Saldo = this.Saldo + value;
                Console.WriteLine("Depósito de " + value + " reais realizado com sucesso na conta de " + Dono);
            } else
            {
                Console.WriteLine("Impossível depositar em uma conta fechada!");
            }
        }
        public void sacar(double value)
        {
            if(this.Status)
            {
                if(this.Saldo >= value)
                {
                    this.Saldo = this.Saldo - value;
                    Console.WriteLine("Saque de " + value + " reais realizado na conta de " + Dono + ".");
                } else
                {
                    Console.WriteLine("Saldo insuficiente para saque!");
                }
            } else 
            {
                Console.WriteLine("Impossível sacar de uma conta fechada!");
            }
        }
        public void pagarMensal(int value) 
        {
            if(this.Tipo == "CC")
            {
                value = 12;
            } else if (this.Tipo =="CP")
            {
                value = 20;
            }
            if(this.Status)
            {
                this.Saldo = this.Saldo - value;
                Console.WriteLine("Mensalidade de " + value + " reais paga com sucesso por " + this.Dono + "!");
            } else
            {
                Console.WriteLine("Impossível pagar uma conta fechada!");
            }
        }

         public ContaBanco() //método construtor
        {
            this.Saldo = 0;
            this.Status = false;
        }
        
        public int NumConta
        {
            get { return this.numConta; }
            set { this.numConta = value; }
        }
        
        public string Tipo 
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public string Dono 
        {
            get { return this.dono; }
            set { this.dono = value; }
        }

        public double Saldo 
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        public bool Status 
        {
            get { return this.status; }
            set { this.status = value; } 
        }

    }
}
