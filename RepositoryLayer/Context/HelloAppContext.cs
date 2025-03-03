using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Context
{
    public class HelloAppContext : DbContext
    {
        public HelloAppContext(DbContextOptions<HelloAppContext> options) : base(options) //constructor
        {

        }
        public virtual DbSet<UserEntity> Users { get; set; } //dbset database mee jo table bnegi wo userentity ke basis pe bnegi users is tablename
    }
}
