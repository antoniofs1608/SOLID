namespace SOLID_ComCSharp
{
    class OCP_Boa
    {
    }


    // Bom:
    interface Remuneravel
    {
        public decimal Remuneracao();
    }

    class ContratoClt : Remuneravel
    {
        public decimal Remuneracao()
        {
            return 0;
        }
    }

    class Estagio : Remuneravel
    {
        public decimal Remuneracao()
        {
            return 0;
        }
    }

    class FolhaDePagamento
    {
        protected decimal saldo;
        public void Calcular(Remuneravel funcionario)
        {
            this.saldo = funcionario.Remuneracao();
        }
    }
}
