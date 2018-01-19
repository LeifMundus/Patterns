using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DilmanovaDZ2Patterns
{
    public class CLient
    {
        public void AngusBurgerCombo(HardeesBurgerMaker hbmFacade)
        {
            hbmFacade.abcMaker();
           
        }
    }
    public class HardeesBurgerMaker
    {
        BriocheBread briocheBread;
        CheeseSlices cheeseSlices;
        BeefBurgerPatty beefBurgerPatty;
        ComboMaker comboMaker;
        public HardeesBurgerMaker(BriocheBread brBr, CheeseSlices chSl, BeefBurgerPatty bbp, ComboMaker cm)
        {
            briocheBread = brBr;
            cheeseSlices = chSl;
            beefBurgerPatty = bbp;
            comboMaker = cm;
        }
        public void abcMaker()
        {
            briocheBread.BriocheBreadMaker();
            Thread.Sleep(1000);
            cheeseSlices.CheeseSlicesMaker();
            Thread.Sleep(1000);
            beefBurgerPatty.BgpMaker();
            Thread.Sleep(1000);
            comboMaker.FriesMaker();
            comboMaker.PourCola();
            Thread.Sleep(1000);
            Console.WriteLine("Your Angus Burger Combo is ready! Take it!");
            Console.ReadLine();
        }
    }
    public class BriocheBread
    {
        public void BriocheBreadMaker()
        {
            Console.WriteLine("Brioche Bread is ready!");
            
            
        }
    }

    public class CheeseSlices
    {
        public void CheeseSlicesMaker()
        {
            Console.WriteLine("Cheese Slices are ready!");
            
        }
    }
    public class BeefBurgerPatty
    {
        public void BgpMaker()
        {
            Console.WriteLine("Beef Burger Patty is ready!");
           
        }
    }

    public class ComboMaker
    {
        public void PourCola()
        {
            Console.WriteLine("CocaCola is ready!");
           
        }
        public void FriesMaker()
        {
            Console.WriteLine("Fries is ready!");
           
        }
    }
    
        
    
}
