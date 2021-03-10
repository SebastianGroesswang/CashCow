using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashcow.Logic.Entities
{
    internal class IdentityEntity : Cashcow.Contracts.IIdentifiable
    {
        public int Id { get; set; }
    }
}
