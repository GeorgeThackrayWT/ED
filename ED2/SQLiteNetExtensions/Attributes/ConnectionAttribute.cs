using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTSqLExt.Attributes
{
   
        [AttributeUsage(AttributeTargets.Property)]

        public class ConnectionAttribute : Attribute
        {
            public ConnectionAttribute()
            {
            }
        }
    
}
