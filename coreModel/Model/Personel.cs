using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace coreModel.Model
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public string NameSurname { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string ShiftStatus { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        
        public int TaskksId { get; set; }
        [ForeignKey("TaskksId")]
        public Taskks Taskks { get; set; }
        
        public int TitleId { get; set; }
        [ForeignKey("TitleId")]
        public Titles Title { get; set; }
    }
}
