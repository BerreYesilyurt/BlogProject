using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(30)]
        public string CategoryName { get; set; }

        [StringLength(500)]
        public string CategoryDescription { get; set; } 

        public ICollection<Blog> Blogs { get; set; }/* Herhangi bir kategori, birden çok blogu kapsayabilir. Birden çoğa bir ilişki söz konudur. Koleksiyonlar nesneleri gruplamaya yarayan sınıflardır.*/
    }
}
