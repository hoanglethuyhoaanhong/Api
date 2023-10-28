using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Data
{
    [Table("NguoiDung")]
    public class NguoiDung
    {
        [Key]
        public int MA_USER { get; set; }
        
        [MaxLength(50)]
        public string HO { get; set; }
        
        [MaxLength(30)]
        public string TEN { get; set; }
        [Required]
        [MaxLength(40)]
        public string GMAIL { get; set; }
        [Required]
        [MaxLength(9)]
        public string KIEU { get; set; }
        [Required]
        [MaxLength(50)]
        public string TENTK { get; set; }
        [Required]
        [MaxLength(20)]
        public string MATKHAU { get; set; }
        public ICollection<CHITIETTHANHTUU> CHITIETTHANHTUUs { get; set; }
        public NguoiDung()
        {
            CHITIETTHANHTUUs = new List<CHITIETTHANHTUU>();
        }


    }
}
