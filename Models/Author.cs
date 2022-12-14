using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Pavel_Eduard_Cristian_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "Author Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName 
        { 
            get 
            { 
                return FirstName + " " + LastName; 
            } 
        }
        public ICollection<Book>? Books { get; set; }
    }
}
