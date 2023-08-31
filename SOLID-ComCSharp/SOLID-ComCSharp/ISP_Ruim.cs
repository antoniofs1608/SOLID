using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_ComCSharp
{
    class ISP_Ruim
    {
    }

    interface Aves_RUIM
    {
        public decimal SetLocalizacao();
        public decimal SetAltitude();
        public decimal Renderizar();
    }

    class Papagaio_RUIM : Aves_RUIM
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

    class Pinguim_RUIM : Aves_RUIM
    {
        public decimal SetLocalizacao()
        {
            return 0;
        }

        // A Interface Aves está forçando a Classe Pinguim a implementar esse método.
        // Isso viola o príncipio ISP
        public decimal SetAltitude()
        {
            // Pinguins são aves que não voam!
            return 0;
        }
        public decimal Renderizar()
        {
            return 0;
        }
    }

}
