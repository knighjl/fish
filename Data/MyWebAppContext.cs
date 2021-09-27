using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myWebApp.Models;

    public class MyWebAppContext : DbContext
    {
        public MyWebAppContext (DbContextOptions<MyWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<myWebApp.Models.Fish> Fish { get; set; }
    }
