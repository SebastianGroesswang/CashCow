using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBase.Extensions
{
    public static class ObjectExtension
    {
        public static void CheckArgument(this object obj, string name)
        {
            if(obj is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
        }
    }
}
