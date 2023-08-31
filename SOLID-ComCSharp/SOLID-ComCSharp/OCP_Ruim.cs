namespace SOLID_ComCSharp
{
    class OCP_Ruim
    {
    }

    //Ruim:
    class ContratoClt_RUIM
    {
        public void Salario()
        {
            //...
        }
    }

    class Estagio_RUIM
    {
        public void BolsaAuxilio()
        {
            //...
        }
    }

    class FolhaDePagamento_RUIM
    {
        private dynamic saldo;

        public void Calcular_RUIM(dynamic funcionario)
        {
            if (funcionario is ContratoClt_RUIM)
            {
                saldo = funcionario.salario();
            }
            else if (funcionario is Estagio_RUIM)
            {
                saldo = funcionario.bolsaAuxilio();
            }
        }
    }
}
