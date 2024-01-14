using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using core_web_app1.Models;

namespace core_web_app1.Data
{
    public class core_web_app1Context : DbContext
    {
        public core_web_app1Context (DbContextOptions<core_web_app1Context> options)
            : base(options)
        {
        }

        public DbSet<core_web_app1.Models.User> User { get; set; } = default!;
    }
}
