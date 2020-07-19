using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 *  Name: Gurkirat Singh Khaira
 *  Student: 301112565
 *  Comp-123
 *  Programming-2
 *  Assignment3
 */
namespace Assignment3
{
    /**
     * <summary>
     * This is the driver class
     * </summary>
     * 
     * @class Program
     */
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate GiantPlanet object
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 139820, 1.89800000000000003e+24, "gas");
            Console.WriteLine(giantPlanet.ToString());

            // Instantiate TerrestrialPlanet object
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Venus", 112104, 4.86700000000000026e+21, false);
            Console.WriteLine(terrestrialPlanet.ToString());
            
            //call for key method
            waitForAnyKey();
        }
        private static void waitForAnyKey()
        {
            //wait for any key
            Console.ReadKey();
        }
    }
}