using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public static class MigrationHelper
    {

        public static void Migrate()
        {
            using (var movieContext = new MovieAppContext())
            {
                movieContext.Database.Migrate();
            }
        }
    }
}
