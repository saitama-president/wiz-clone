using System;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;
using System.Runtime;

namespace WIZC{



  namespace Chara{

    class Character:Common.Data{

    
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


