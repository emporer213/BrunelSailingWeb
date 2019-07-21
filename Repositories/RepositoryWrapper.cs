using Brunel_Sailing_Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brunel_Sailing_Web.Repositories
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private ApplicationContext _context;
        private IUserRepository _user;
        private IPostRepository _post;
        private IEventRepository _event;
        private IRoleRepository _role;
        
        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_context);
                }
                return _user;
            }
        }

        public IPostRepository Post
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_context);
                }
                return _post;
            }
        }

        public IEventRepository Event
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_context);
                }
                return _event;
            }
        }

        public IRoleRepository Role
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_context);
                }
                return _role;
            }
        }

        public RepositoryWrapper(ApplicationContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
