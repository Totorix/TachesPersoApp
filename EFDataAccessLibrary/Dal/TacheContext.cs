using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.Dal
{
    public class TacheContext : DbContext
    {
        public TacheContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Tache> Taches { get; set; }

        public DbSet<Acte> Actes { get; set; }

    }

}
