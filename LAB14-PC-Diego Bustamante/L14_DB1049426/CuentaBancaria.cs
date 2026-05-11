using System;

namespace L14_DB1049426
{
    class CuentaBancaria
    {
        public string titular;
        public string numeroCuenta;
        public decimal saldo;

        //Constructor

        public CuentaBancaria(string titular, string numeroCuenta, decimal saldo)
        {
            this.titular = titular;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
        }

        //Mostrar informacion

        public void MostrarInformacion()
        {
            Console.WriteLine("\nTitular: " + titular);
            Console.WriteLine("Numero de cuenta: " + numeroCuenta);
            Console.WriteLine("Saldo: Q" + saldo);
        }

        //Depositar

        public void Depositar(decimal monto)
        {
            saldo += monto;

            Console.WriteLine("Deposito realizado");
        }

        //Retirar

        public void Retirar(decimal monto)
        {
            if (saldo >= monto)
            {
                saldo -= monto;

                Console.WriteLine("Retiro realizado");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes");
            }
        }
    }
}