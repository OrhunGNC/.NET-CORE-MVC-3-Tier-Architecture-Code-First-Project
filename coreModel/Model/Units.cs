using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreModel.Model
{
    public class Units
    {
        [Key]
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int NumbofEmployee { get; set; }
        
        public int TaskksId { get; set; }
        [ForeignKey("TaskksId")]
        public Taskks Taskks { get; set; }
    }
}
