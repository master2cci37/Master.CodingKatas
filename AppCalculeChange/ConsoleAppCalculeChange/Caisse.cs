using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculeChange
{
    public enum Valeur
    {
        Cent, DeuxCents, CinqCents, DixCents, VingtCents,
        CinquanteCents, UnEuro, DeuxEuros, CinqEuros, DixEuros,
        VingtEuros, CinquanteEuros, CentEuros, DeuxCentsEuros,
        CinqCentsEuros
    }

    public class Caisse
    {
        public Change[] RetourneChange(decimal prix, decimal paiement)
        {
            return null;
        }


    }

    public class Change
    {
        public int Quantite { get; set; }
        public Valeur Valeur { get; set; }

    }
}
