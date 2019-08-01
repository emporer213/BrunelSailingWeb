using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brunel_Sailing_Web.Data
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
