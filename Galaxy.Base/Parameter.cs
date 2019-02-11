using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Base
{

    public class Parameter:BusinessObject
    {
        public virtual int Value { get; set; }
        public virtual string Name { get; set; }
    }
}
