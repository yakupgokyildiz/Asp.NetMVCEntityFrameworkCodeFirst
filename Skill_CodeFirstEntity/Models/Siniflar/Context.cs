using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;

namespace Skill_CodeFirstEntity.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Yetenek> Yeteneks { get; set; }
    }
}