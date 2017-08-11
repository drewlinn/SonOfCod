using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod.Models
{
    [Table("Newsletters")]
    public class Newsletter
    {
        [Key]
        public int id { get; set; }
        public string letter { get; set; }
        public string authorId { get; set; }
        public DateTime date { get; set; }
    }
}
