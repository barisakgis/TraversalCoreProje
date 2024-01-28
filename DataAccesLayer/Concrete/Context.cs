﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI\\SQLEXPRESS2022;database=TraversalDB; integrated security=true");
        }
        //  Identity kendisi otomatik role claim user gibi tabloları oluşturacak 
        // entityleri db yansıtmak için 
        public DbSet<About>  Abouts { get; set; }
        public DbSet<About2>   About2s { get; set; }
        public DbSet<Contact>   Contacts { get; set; }
        public DbSet<Destination>   Destinations { get; set; }
        public DbSet<Feature>   Features { get; set; }
        public DbSet<Feature2>   Feature2s { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter>   Newsletters { get; set; }
        public DbSet<SubAbout>   SubAbouts { get; set; }
        public DbSet<TestiMonial>  TestiMonials { get; set; }
        public DbSet<Comment>  Comments { get; set; }
         public DbSet<Reservation>  Reservations { get; set; }

    }
}