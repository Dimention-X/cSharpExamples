using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes_Test
{
    class Obsolute_Attribute
    {
        public static void Play()
        {
            Console.WriteLine("Play the songs from Play method");
        }

        [Obsolete("Please don't use this method")]
        public  static void Play1()
        {
            Console.WriteLine("Plaging from the obsulte method attribbute");
        }

        [Obsolete("Please don't use this gives an error",true)]
        public static void Play2()
        {
            Console.WriteLine("implimenting both the perametr of the Obsulte");
        }
    }
}
