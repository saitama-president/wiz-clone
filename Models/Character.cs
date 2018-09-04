using System;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;
using System.Runtime;

namespace WIZC{

  namespace Common{
    abstract class Data{

      public static int N=10;
    }

    abstract class Master<T>
    where T:Data
    {
      public List<T> loadMaster(){
        return null;
      }
      
    }

  }

  namespace Chara{

    class Character:WIZC.Common.Data{

    
      public static void import(){
        var json=JsonConvert.SerializeObject("掴もうぜ");

        string jsoned=JsonConvert.DeserializeObject<string>(json);
        
        Console.WriteLine(jsoned);
      }
    }

    class CharacterClass{
      string name;
      
    }
  }
}


