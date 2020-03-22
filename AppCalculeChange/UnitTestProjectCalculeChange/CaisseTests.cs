using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppCalculeChange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculeChange.Tests
{
    [TestClass()]
    public class CaisseTests
    {
        [TestMethod()]
        public void RetourneChange1010Test()
        {
            var caisse = new Caisse();
            var resultat = caisse.RetourneChange(10, 10);
            Change[] attendu=null;
            Assert.AreEqual(attendu, resultat);
        }

        /* tests à  valider 
         10  /  10  => 0 -

 0.85 /  1.00 => 1   CinqCents,  1  DixCents,

  1.95 / 5  =>  3 UnEuros,  1 CinquanteCents

 22.50  / 50  => 1 VingEuros, 1 CinqEuros, 1 DeuxEuros,  1 CinquanteCents

 13.09 /  200.00 =>       1  CentEuros,     1 CinquanteEuros       1 VingtEuros,       1 DixEuros,         1 CinqEuros,     1  UnEuro,          1 CinquanteCents,    2 VingtCents,        1 Cent 
         * */
    }
}