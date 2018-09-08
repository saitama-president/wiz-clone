using System;
using WIZC.Chara;
using Common;

namespace Wiz_Clone_Console
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Run Start");
          Character c=new Character();
          Console.WriteLine(c);
          
          Console.WriteLine("C={0} D={1}",Character.N,Data.N);
          Console.WriteLine("BEGIN"); 

          var v=WizClone.TestMaster.loadMaster("test.json");
          Console.WriteLine("FE"); 
          foreach(WizClone.TestData t in v){
            Console.WriteLine(t);
        
          }
          Console.WriteLine(v);
    
        }
    }
}
