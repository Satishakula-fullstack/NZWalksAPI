using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NZWalks.API
{
    public class NZWalksDbContext:DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options):base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk>  Walks{ get; set; }
        public DbSet<WalkDifficulty> WalkDifficultiess { get; set; }

    }
}
