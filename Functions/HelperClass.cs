using System;
using BackEnd;
using Microsoft.EntityFrameworkCore;

namespace Functions
{
    public static class HelperClass
    {
        public static FunctionClass functions = new FunctionClass();

        public static void Migrate()
        {
            using (var movieContext = new MovieAppContext())
            {
                movieContext.Database.Migrate();
            }
        }
    }
}
