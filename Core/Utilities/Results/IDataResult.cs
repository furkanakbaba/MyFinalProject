using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult//DataResultta da bool ve success döndüreceğimiz için implemente yaptık.
        //T dödnürmek istediğimiz data tipini belirtiyor.
    {
        
        T Data { get; }
    }
}
