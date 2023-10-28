using MyWebAPI.Data;
using MyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
namespace MyWebAPI.Services
{
    public class NguoiDungRepository : INguoiDungRepository
    {
        private readonly MyDBContext _context;

        public NguoiDungRepository(MyDBContext context)
        {
            _context = context;
            
        }
        public NguoiDungVM Add(NguoiDungModel nguoidung)
        {
            var _nguoidung = new NguoiDung
            {
                TEN = nguoidung.TEN

            };
            _context.Add(_nguoidung);
            _context.SaveChanges();
            return new NguoiDungVM
            {
                MA_USER = _nguoidung.MA_USER,
                MATKHAU = _nguoidung.MATKHAU,
                TEN = _nguoidung.TEN,
                HO = _nguoidung.HO,
                TENTK = _nguoidung.TENTK,
                GMAIL = _nguoidung.GMAIL,
                KIEU = _nguoidung.KIEU,
            };

        }

        public void Delete(int id)
        {
            var nguoidung = _context.NguoiDungs.SingleOrDefault(nd => nd.MA_USER == id);
            if(nguoidung != null)
            {
                _context.Remove(nguoidung);
                _context.SaveChanges();
            }
        }

        public List<NguoiDungVM> GetAll()
        {
            var nguoidungs = _context.NguoiDungs.Select(nd => new NguoiDungVM {
                MA_USER = nd.MA_USER,
                MATKHAU = nd.MATKHAU,
                HO = nd.HO,
                TEN = nd.TEN,
                GMAIL = nd.GMAIL,
                TENTK = nd.TENTK



            });
            return nguoidungs.ToList();
        }

        public NguoiDungVM GetById(int id)
        {
            var nguoidung = _context.NguoiDungs.SingleOrDefault(nd => nd.MA_USER == id);
            if (nguoidung == null)
            {
                return new NguoiDungVM
                { MA_USER = nguoidung.MA_USER,
                    MATKHAU = nguoidung.MATKHAU,
                    HO = nguoidung.HO,
                    TEN = nguoidung.TEN,
                    GMAIL = nguoidung.GMAIL,
                    TENTK = nguoidung.TENTK
                };
                

            }
            return null;
        }

        public void Update(NguoiDungVM nguoidung, int id)
        {
            var _nguoidung = _context.NguoiDungs.SingleOrDefault(nd => nd.MA_USER == id);
            nguoidung.TEN = _nguoidung.TEN;
            _context.SaveChanges();
        }

        public void Update(NguoiDungVM nguoidung)
        {
            throw new NotImplementedException();
        }
    }
}
