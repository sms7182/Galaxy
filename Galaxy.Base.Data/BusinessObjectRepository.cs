using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Base.Data
{
    public class BusinessObjectRepository : IBusinessObjectRepository
    {
        public void Persist()
        {
           Console.Write("Ok");
        }
    }
}
