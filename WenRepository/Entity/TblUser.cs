using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WenRepository.Entity
{
    
    public  class TblUser
    {

        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public long MobileNo { get; set; }
    }
}
