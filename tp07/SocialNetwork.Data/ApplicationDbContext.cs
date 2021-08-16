﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SocialNetwork.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SocialNetwork.Domain.Entities.Developer> Developer { get; set; }
        public DbSet<SocialNetwork.Domain.Entities.Profile> Profile { get; set; }
    }
}
