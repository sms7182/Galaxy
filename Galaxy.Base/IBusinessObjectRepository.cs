using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Base
{
    public interface IBusinessObjectRepository
    {

    }
   
    public interface IBusinessObjectRepository<T>:IBusinessObjectRepository where  T : BusinessObject
    {
        void Persist();
    }
}
