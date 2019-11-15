using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationn.Models;

namespace WebApplicationn.Data
{
    public class ContactoContexto : DbContext
    {
        public ContactoContexto(DbContextOptions<ContactoContexto>options):base(options)
        {

        }
        //Crear nuestro dbset
        public DbSet<Contacto> ContactoItems { get; set; }
    }
}
