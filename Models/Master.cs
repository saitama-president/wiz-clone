using System;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;
using System.Runtime;
using System.IO;
using System.Text;
namespace Common
{
  public abstract class Data
  {

    public static int N = 10;
  }

  public abstract class Master<TT>
  where TT : Data
  {
    public static List<TT> loadMaster(string path)
    {

      using(StreamReader　r=new StreamReader(
        path,
        Encoding.UTF8
        )){
          
          
          return JsonConvert.DeserializeObject<List<TT>>(
            r.ReadToEnd());
        }
        return null;
    }

  }

}