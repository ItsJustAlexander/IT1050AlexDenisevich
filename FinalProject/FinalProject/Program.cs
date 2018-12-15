using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero("Batman", "Gadgets", "Joker", "Fly");
            Hero myOtherHero = new Hero("IronMan", "Thor", "Human", "Fly", true);
            Hero thirdHero = new Hero("CaptainAmerica", "All bad people", "America", "Stength, Speed");

            myHero.ChargePower(100);
            myHero.FightCrime("Gothem");
            myHero.Investigate();
            myHero.Fly();
            myHero.Craft("Metal", 300);
            myHero.Climb(100);

            myOtherHero.ChargePower(100);
            myOtherHero.FightCrime("New York");
            myOtherHero.Investigate();
            myOtherHero.Fly();
            myOtherHero.Climb(200);

            thirdHero.ChargePower(100);
            thirdHero.FightCrime("America");
            thirdHero.Investigate();
            thirdHero.Fly();
            thirdHero.Climb(300);
            

            /*
                Problem 7:
                Each Hero must:
                 - ChargePower (as much as you want)
                 - Investigate
                 - FightCrime (at least one must win. at least one must not win)
                 - Fly (at least one superhero should be able to fly)
                 - Climb
            */
          

        }
    }
}
