using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashcow.Logic.DataContext
{
    internal class MyDbContext : DbContext, Contracts.IContext
    {
    }
}
