using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WenRepository.Entity
{
    public  class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal? Price { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public TblUser tblUsers { get; set; }

    }
}
