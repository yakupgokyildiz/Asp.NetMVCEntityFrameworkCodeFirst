using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Skill_CodeFirstEntity.Models.Siniflar
{
    public class Yetenek
    {
        [Key]
        public int ID { get; set; }
        public string Aciklama { get; set; }
        public byte Deger { get; set; }

    }
}