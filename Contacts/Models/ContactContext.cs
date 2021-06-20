using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Models
{
    public class ContactContext:DbContext

    {
        public ContactContext(DbContextOptions<ContactContext> options):base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Angeline",
                    PhoneNumber = 9910456545,
                    Address = "454, Laurel St, California",
                    Note = "School Friend"
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Rajakumar",
                    PhoneNumber = 8945786231,
                    Address = "589, Kings St, Texas",
                    Note = "Neighbour"
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "Jeshlin",
                    PhoneNumber = 8521463335,
                    Address = "111, Sagewood St, Iowa",
                    Note = "School Teacher"
                },
                new Contact
                {
                    ContactId = 4,
                    Name = "Ferryn",
                    PhoneNumber = 5152202323,
                    Address = "785, Samsung St, Iowa",
                    Note = "Mercy Doctor"
                },
                new Contact
                {
                    ContactId = 5,
                    Name = "Braydon",
                    PhoneNumber = 9005157723,
                    Address = "412, Hickman St, California",
                    Note = "Colleague"
                },
                new Contact
                {
                    ContactId = 6,
                    Name = "Jacklin",
                    PhoneNumber = 5152124544,
                    Address = "155, Milton Ave, California",
                    Note = "Relative"
                }
                );
        }
    }
}