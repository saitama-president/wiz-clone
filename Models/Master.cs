using System;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;
using System.Runtime;
using System.IO;
using System.Text;
namespace Common
{
  abstract class Data
  {

    public static int N = 10;
  }

  abstract class Master<T>
  where T : Data
  {
    public List<T> loadMaster(string path)
    {

      using(StreamReader　r=new StreamReader(
        path,
        Encoding.UTF8
        )){
          

          JsonConvert.DeserializeObject<List<T>>(r.ReadToEnd());
        }
      return null;
    }

  }

}