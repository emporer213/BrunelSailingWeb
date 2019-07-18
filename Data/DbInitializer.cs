using Brunel_Sailing_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brunel_Sailing_Web.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User{FirstName="Dominic",LastName="Bedwin",Username="LevG",Password="Admin",RoleId=1},
                new User{FirstName="Phoebe",LastName="Jones",Username="PJones",Password="PJones123",RoleId=1},
                new User{FirstName="Dan",LastName="Fox",Username="DFox",Password="DFox123",RoleId=1},
                new User{FirstName="Edward",LastName="Cray",Username="ECray",Password="ECray123",RoleId=1}
            };

            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var roles = new Role[]
            {
                new Role{RoleName="SuperAdmin",CreateEvents=true,EditEvents=true,DeleteEvents=true,CreateUsers=true,EditUsers=true,DeleteUsers=true,CreatePosts=true,EditPosts=true,
                DeletePosts=true,ManagePermissions=true,SiteConfig=true}
            };
            
            foreach (Role r in roles)
            {
                context.Roles.Add(r);
            }
            context.SaveChanges();

            var posts = new Post[]
            {
                new Post{Tags="test,new,sailing,setup,lol,bacon",ShortDesc="<p>This is a short description of what is going to be in the post and briefly summerises it!</p>",
                Content="<p>This is the content of the post is includes lots of useful information about the sailing club<br> The club is really awesome<br> We have boats yay!<br>" +
                "Thanks for reading</p>",PostDate=DateTime.Now,UserId=1}
            };

            foreach (Post p in posts)
            {
                context.Posts.Add(p);
            }
            context.SaveChanges();

            var events = new Event[]
            {
                new Event{Tags="test,new,badger,sailing,setup",ShortDesc="<p>This is where the badger would go if we had a plan</p>", Content="<p>YO BRO!!!!<br><br>COME CHECK OUT " +
                "OUR AWESOME NEW EVENT DUDES!!!<br>It's got BOATS<br>It's got HOES<br>What's not to like come check it out!!</p>",PostDate=DateTime.Now,UserId=2,StartDate=DateTime.Now.AddMonths(3),
                EndDate=DateTime.Now.AddMonths(4)}
            };

            foreach (Event e in events)
            {
                context.Events.Add(e);
            }
            context.SaveChanges();
        }
    }
}
