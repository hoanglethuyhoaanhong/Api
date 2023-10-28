using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Data
{
    public class CHITIETTHANHTUU
    {
        [Key]
        public Guid ID_CTTT { get; set; }
        [Required]
        [MaxLength(10)]
        public Guid MA_THANHTUU { get; set; }
        [ForeignKey("MA_THANHTUU")]
        public ThanhTuu ThanhTuu { get; set; }
        [Required]
        [MaxLength(10)]
        public int MA_USER { get; set; }
        [ForeignKey("MA_USER")]
        public NguoiDung NguoiDung { get; set; }
        public string MOTA { get; set; }

        
    }
}
