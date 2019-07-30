using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppCF.Models
{
   public class Passport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime GivenDate { get; set; }
        public string GivenOrg { get; set; }
        public DateTime ExpireDate { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
