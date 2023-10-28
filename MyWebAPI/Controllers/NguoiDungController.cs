
    
   
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Data;
//using MyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NguoiDungController : Controller
    {
        public static List<NguoiDung> nguoidungs = new List<NguoiDung>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(nguoidungs);
        }
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                // LINQ [Oject] Query
                var hangHoa = nguoidungs.SingleOrDefault(hh => hh.MA_USER == int.Parse(id));
                if (hangHoa == null)
                {
                    return NotFound();

                }
                return Ok(hangHoa);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult Create(NguoiDung nguoiDung)
        {
            var nguoidung = new NguoiDung
            {
                MA_USER = nguoiDung.MA_USER,
                HO = nguoiDung.HO,
                TEN = nguoiDung.TEN,
                TENTK = nguoiDung.TENTK,
                MATKHAU = nguoiDung.MATKHAU,
                GMAIL = nguoiDung.GMAIL

            };
            nguoidungs.Add(nguoidung);
            return Ok(new
            {
                Success = true,
                Data = nguoidung
            });
        }
        [HttpPut("{id}")]
        public IActionResult Edit(string id, NguoiDung nguoiDungEdit)
        {
            try
            {
                // LINQ [Oject] Query
                var nguoiDung = nguoidungs.SingleOrDefault(hh => hh.MA_USER == int.Parse(id));
                if (nguoiDung == null)
                {
                    return NotFound();

                }
                if (id != nguoiDung.MA_USER.ToString())
                {
                    return BadRequest();
                }
                //update
                nguoiDung.TENTK = nguoiDungEdit.TENTK;
                nguoiDung.MATKHAU = nguoiDungEdit.MATKHAU;

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                // LINQ [Oject] Query
                var nguoiDung = nguoidungs.SingleOrDefault(hh => hh.MA_USER == int.Parse(id));
                if (nguoiDung == null)
                {
                    return NotFound();

                }
                if (id != nguoiDung.MA_USER.ToString())
                {
                    return BadRequest();
                }
                //update
                nguoidungs.Remove(nguoiDung);

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
