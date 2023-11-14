﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order:CommonEntity,IEntity
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Piece { get; set; }
        //public Product OrderedProduct { get; set; }
    }
}