using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
namespace MyWebAPI.Models
{
    public class NguoiDungVM
    {
        public int MA_USER { get; set; }
        public string HO { get; set; }


        public string TEN { get; set; }

        public string GMAIL { get; set; }

        public string KIEU { get; set; }

        public string TENTK { get; set; }

        public string MATKHAU { get; set; }
    }
}
