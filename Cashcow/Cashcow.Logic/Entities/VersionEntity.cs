using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashcow.Logic.Entities
{
    internal class VersionEntity : IdentityEntity, Cashcow.Contracts.IVersionable
    {
        public byte[] RowVersion { get; set; }
    }
}
