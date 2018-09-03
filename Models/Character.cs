using System;
using Newtonsoft.Json;
using System.Runtime;

namespace WizClone{
  namespace Chara{

    class Character{
    
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


