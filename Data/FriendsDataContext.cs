using Friends.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Data
{
    public class FriendsDataContext : DbContext
    {
        public FriendsDataContext(DbContextOptions<FriendsDataContext> options)
           : base(options)
        {
        }
        
        public DbSet<Value> Values { get; set; }
    }
}
