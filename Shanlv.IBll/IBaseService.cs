using System;
using System.Collections;

namespace Shanlv.IBll
{
    public interface IBaseService<T> where T : class, new()
    {

        int Add(T model);


        //public void Method()
        //{

        //}

        //public void Method()
        //{

        //}
    }
}
