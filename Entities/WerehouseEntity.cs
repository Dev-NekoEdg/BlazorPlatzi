using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WerehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WerehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WerehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WerehouseAddress { get; set; }
    }
}
