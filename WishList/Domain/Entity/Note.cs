using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Note
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Type { get; set; }
    }
}
