using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WenRepository.Entity
{
   
    public class Testing11
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserIds { get; set; }
        [ForeignKey("UserIds")]
        public virtual TblUser? tbluserss { get; set; }
    }
}
