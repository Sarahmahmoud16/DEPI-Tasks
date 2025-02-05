using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task_Part01.Model
{
    public class Product
    {
        
        public  int Id { get; set; }

        [Column(TypeName ="varchar(50)")]
        [Required]
        [DefaultValue("OurProject")]
        public string Name { get; set; }

         
        [Range(500000,3500000)]
        public decimal cost { get; set; }
    }
}
