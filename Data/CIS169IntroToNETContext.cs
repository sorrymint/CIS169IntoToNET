using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CIS169IntroToNET.Model;

namespace CIS169IntroToNET.Data
{
    public class CIS169IntroToNETContext : DbContext, IEnumerable
    {
        public CIS169IntroToNETContext (DbContextOptions<CIS169IntroToNETContext> options)
            : base(options)
        {
        }

        public DbSet<CIS169IntroToNET.Model.Course> Course { get; set; } = default!;
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}