using System;
using System.Collections.Generic;
using System.Linq;
using AspCoreWebApp.Business.Abstract;
using AspCoreWebApp.DataAccess.Abstract;
using AspCoreWebApp.DataAccess.Concrete;
using AspCoreWebApp.Entities.Models;


namespace AspCoreWebApp.Business.Concrete
{
    public class DepartmanManager : IDepartmanService
    {
        private IDepartmanRepository _departmanRepository;

        public DepartmanManager()
        {
            _departmanRepository = new DepartmanRepository();
        }
        public List<Departman> GetAllDepartmans()
        {
            return _departmanRepository.GetAllDepartmans().ToList();
        }

        public Departman GetDepartmanById(int id)
        {
            //Örnek iş kuralı
            if (id>1)
            {
                return _departmanRepository.GetDepartmanById(id);
            }

            throw new Exception("id can not be less than 1");

        }

        public Departman CreateDepartman(Departman departman)
        {
            return _departmanRepository.CreateDepartman(departman);
        }

        public Departman UpdateDepartman(Departman departman)
        {
            return _departmanRepository.updateDepartman(departman);
        }

        public void DeleteDepartman(int id)
        {
            _departmanRepository.DeleteDepartman(id);
        }
    }
}