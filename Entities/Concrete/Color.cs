using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    class Color:IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
