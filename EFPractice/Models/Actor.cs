using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPractice.Models
{
   public class Actor
    {
        [Key]
        public int Id { set; get;  }
        public string Name { set; get; }
        public bool IsAcademyAwardWinner { set; get; } = false;

    }
}
