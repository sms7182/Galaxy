using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Base.Data
{
    public class BusinessObjectRepository
    {

    }
    public abstract class BusinessObjectRepository<T> :BusinessObjectRepository,IBusinessObjectRepository<T> where T:BusinessObject
    {
        public virtual void Persist()
        {
            Console.Write("Ok");
        }
    }
}
