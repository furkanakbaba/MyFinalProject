using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult //Burası bizim base classımız.
    {
        //bu alanda farklı geri dönüşleri yazdık.
        public Result(bool success, string message) : this(success)//ctor -- this success = bu ctor çalışırken aşağıdakini baz alıp çalışsın.
        {
            Message = message;
        }
        public Result(bool success)//ctor
        {
            Success = success;
        }

        public bool Success { get; }
            
        public string Message { get; }
    }
}
