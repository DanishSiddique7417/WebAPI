using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WenRepository.Entity
{
    public  class MasterTable
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="varchar(100)")]    
        public string? Name { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        [Column(TypeName ="char(10)")]
        public string? Mobile { get; set; }

        public int UserId { get;set; }
        [ForeignKey("UserId")]
        public virtual TblUser? usr { get; set; }
    }

    public class MasterTable1
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string? Name { get; set; }
       

        [Range(18,60)]
        public int? Age { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string? Description { get; set; }
        [Column(TypeName = "char(10)")]
        public string? Mobile { get; set; }

        public DateTime? Getdate { get; set; }  

       
    }

    public class MasterTable2
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string? Name { get; set; }


        [Range(18, 60)]
        public int? Age { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string? Description { get; set; }
        [Column(TypeName = "char(10)")]
        public string? Mobile { get; set; }

        public DateTime? Getdate { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        
        public TblUser tblUsers { get; set; }


    }
}
