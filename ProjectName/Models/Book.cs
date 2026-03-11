using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Column("Title")]
        public string Title { get; set; }
        [Column("Genre")]
        public string Genre { get; set; }
    }
}
