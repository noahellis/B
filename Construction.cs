using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ProblemSetB
{
    class Construction
    {
        
        public void OpenVideo()
        {
            Console.WriteLine("Hey there friend!! Want to watch a cool video??");
            Thread.Sleep(2000);
            Console.WriteLine("Well, do ya??");
            Thread.Sleep(2000);
            Console.WriteLine("Press something already...");
            Console.ReadKey();
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=hl_9_q_uLF8");
            Thread.Sleep(2000);
            GC.Collect();  
            
        }
        ~Construction()
        {
            System.Diagnostics.Process.Start("https://youtu.be/JwXohnAYyuc?t=22s ");
        }

    }
}
