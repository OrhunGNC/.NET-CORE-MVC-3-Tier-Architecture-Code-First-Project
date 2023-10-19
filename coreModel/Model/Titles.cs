using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreModel.Model
{
    public class Titles
    {
        [Key]
        public int TitleId { get; set; }
        public string TitleName { get; set; }
    }
}
