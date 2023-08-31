using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_ComCSharp
{
    class ISP_Boa
    {
    }

    interface Aves
    {
        public decimal SetLocalizacao();
        public decimal Renderizar();
    }

    interface AvesQueVoam : Aves
    {
        public decimal SetAltitude();
    }

    class Papagaio : AvesQueVoam
    {
        public decimal SetLocalizacao()
        {
            return 0;
        }
        public decimal SetAltitude()
        {
            return 0;
        }
        public decimal Renderizar()
        {
            return 0;
        }
    }

    class Pinguim : Aves
    {
        public decimal SetLocalizacao()
        {
            return 0;
        }

        public decimal Renderizar()
        {
            return 0;
        }
    }

}
