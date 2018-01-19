using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DilmanovaDZ2Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            BriocheBread briocheBread = new BriocheBread();
            CheeseSlices cheeseSlices = new CheeseSlices();
            BeefBurgerPatty beefBurgerPatty = new BeefBurgerPatty();
            ComboMaker comboMaker = new ComboMaker();

            HardeesBurgerMaker hbm = new HardeesBurgerMaker(briocheBread, cheeseSlices, beefBurgerPatty, comboMaker);

            CLient cLient = new CLient();
            cLient.AngusBurgerCombo(hbm);
        }
    }
}
