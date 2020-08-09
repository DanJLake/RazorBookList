using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBookList.Model
{
    public class Book
    {
        //Set ID as identity/primary key column with [Key]
        [Key]
        public int Id { get; set; }

        //Required properties cannot be null
        [Required]
        public string Name { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}
