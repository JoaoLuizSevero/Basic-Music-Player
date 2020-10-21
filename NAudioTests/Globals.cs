using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAudioTests
{
    class Globals
    {
       public static double semitone = Math.Pow(2, 1.0 / 12);
       public static double upOneTone = semitone * semitone;
       public static double upTwoTone = semitone * semitone *2;
       public static double downOneTone = 1.0 / upOneTone;
       public static double downTwoTone = 1.0 / (2*upOneTone);
       public static string soundPatch = System.IO.Directory.GetCurrentDirectory() + @"\Sounds\";
    }
}
