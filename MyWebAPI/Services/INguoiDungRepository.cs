using MyWebAPI.Data;
using MyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace MyWebAPI.Services
{
    public interface INguoiDungRepository
    {
        List<NguoiDungVM> GetAll();
        NguoiDungVM GetById(int id);
        NguoiDungVM Add(NguoiDungModel nguoidung);
        void Update(NguoiDungVM nguoidung);
        void Delete(int id);

            


    }
}
