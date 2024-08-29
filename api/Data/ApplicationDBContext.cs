using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace api.Data {
    public class ApplicationDBContext: DbContext {

        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) {}
            public DbSet<Room> Room { get; set; }
            public DbSet<Booking> Booking { get; set; }
        
    }
}