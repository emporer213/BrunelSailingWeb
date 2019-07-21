using Brunel_Sailing_Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brunel_Sailing_Web.Data
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IPostRepository Post { get; }
        IEventRepository Event { get; }
        IRoleRepository Role { get; }
        void Save();
    }
}
