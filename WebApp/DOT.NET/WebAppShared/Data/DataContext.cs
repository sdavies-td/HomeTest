﻿using WebApp.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Shared.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
