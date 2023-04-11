using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)//run içerisine istediğim kadar IResult verebilirim
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)//başarılı değilse
                {
                    return logic;//business a hangi kuralın hatalı olduğunu gönderiyoruz.
                }
            }
            return null;
        }
       
    }
}
