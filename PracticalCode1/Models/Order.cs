﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalCode1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<int> ProductIds { get; set; } = new List<int>();
    }
}