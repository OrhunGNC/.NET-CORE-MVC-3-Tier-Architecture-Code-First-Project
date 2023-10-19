using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreModel.Model
{
    public class Taskks
    {
        [Key]
        public int TaskksId { get; set; }
        public string TaskkDescription { get; set; }
        public string TaskkName { get; set; }
        public int TaskkPoint { get; set; }
    }
}
