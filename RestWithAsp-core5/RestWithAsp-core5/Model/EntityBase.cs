using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Model
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
    }
}
