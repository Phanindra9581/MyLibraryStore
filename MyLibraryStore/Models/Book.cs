using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Models
{
    public class Book
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Book Name")]
        [Display(Name ="Book Name")]
        public string BookName { get; set; }

        [Required]
        [Display(Name ="Author Name")]
        public string Author { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Genre { get; set; }

        [Display(Name ="Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
    }
}
