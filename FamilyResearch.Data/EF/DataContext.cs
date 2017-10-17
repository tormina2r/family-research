using FamilyResearch.Data.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.Data.EF
{
    internal class DataContext: DbContext
    {
        public DbSet<PersonEntity> People { get; set; }
    }
}
