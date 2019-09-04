﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DAL
{
    public class DataContext : DbContext
    {

        public DataContext()
        {

        }
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Users> UserModelset { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Data Source=169.254.227.86;Initial Catalog=sssss;User ID=zhaozhehan;pwd=123");
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}