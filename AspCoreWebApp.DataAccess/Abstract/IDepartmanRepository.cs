using System;
using System.Collections.Generic;
using AspCoreWebApp.Entities.Models;

namespace AspCoreWebApp.DataAccess.Abstract
{
    public interface IDepartmanRepository : IDisposable
    {
        
        IEnumerable<Departman> GetAllDepartmans();

        Departman GetDepartmanById(int id);

        Departman CreateDepartman(Departman departman);

        Departman updateDepartman(Departman departman);

        void DeleteDepartman(int id);
    }
}