using System;
using System.Collections;
using System.Collections.Generic;
using Common;

namespace WizClone
{
  class Test
  {
    
    
  }

  class TestData:Data{
    public int A;
    public override string ToString()=>$"{this.A}";

  }

  class TestMaster : Master<TestData>
  {
    public int N;

  }

}
