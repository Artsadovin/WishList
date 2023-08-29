﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Wish
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Type { get; set; }

        public Wish() 
        {
            Created = DateTime.UtcNow;
        }
    }
}
