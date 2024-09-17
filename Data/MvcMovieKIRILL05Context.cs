using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovieKIRILL05.Data
{
    public class MvcMovieKIRILL05Context : DbContext
    {
        public MvcMovieKIRILL05Context (DbContextOptions<MvcMovieKIRILL05Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
