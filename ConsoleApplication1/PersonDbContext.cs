using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using System.Data.Entity;

    /// <summary>
    /// The person db context.
    /// </summary>
    public class PersonDbContext : DbContext
    {
        public PersonDbContext() : base("name=DataModelContext")
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
