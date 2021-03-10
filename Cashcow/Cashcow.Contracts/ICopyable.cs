using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashcow.Contracts
{
    public interface ICopyable<T>
    {
        void CopyProperties(T other);
    }
}
