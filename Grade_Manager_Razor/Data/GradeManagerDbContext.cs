using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Grade_Manager_Razor.Data
{
    public class GradeManagerDbContext :DbContext
    {

        public GradeManagerDbContext(DbContextOptions<GradeManagerDbContext> options)
           : base(options)
        {
        }
    }
}
