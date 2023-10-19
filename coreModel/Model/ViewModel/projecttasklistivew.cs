using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreModel.Model.ViewModel
{
    public class projecttasklistivew
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TaskksId { get; set; }
        public string TaskkDescription { get; set; }
        public string TaskkName { get; set; }
        public int TaskkPoint { get; set; }
    }
}
