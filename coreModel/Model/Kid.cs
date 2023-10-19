using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreModel.Model
{
    public class Kid
    {
        [Key]
        public int KidId { get; set; }
        public string NameSurname { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        [ForeignKey("PersonelId")]
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }
    }
}
