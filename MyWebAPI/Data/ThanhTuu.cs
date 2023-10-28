using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Data
{
    public class ThanhTuu
    {
        [Key]
        public Guid MA_THANHTUU { get; set; }
        [Required]
        [MaxLength(30)]
        public string TENTHANHTUU { get; set; }
        [Required]
        
        public string MOTA { get; set; }
        public ICollection<CHITIETTHANHTUU> CHITIETTHANHTUUs { get; set; }
        public ThanhTuu()
        {
            CHITIETTHANHTUUs = new List<CHITIETTHANHTUU>();
        }

    }
}
