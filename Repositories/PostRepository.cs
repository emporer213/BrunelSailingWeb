using Brunel_Sailing_Web.Data;
using Brunel_Sailing_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brunel_Sailing_Web.Repositories
{
    public class PostRepository: RepositoryBase<Post>, IPostRepository 
    {
        public PostRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
