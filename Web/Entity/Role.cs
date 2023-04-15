using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Data.Entity
{
    public class Role: BaseEntity
    {
        public string Name {get; set;}
        public string Code {get; set;}
    }
}