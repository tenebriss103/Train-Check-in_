﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TrainCheck_in.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options) 
        {
            Database.EnsureCreated();
        }

        public DbSet<Passenger> Passengers { get; set; }
        
    }
}
