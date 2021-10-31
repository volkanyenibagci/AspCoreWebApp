using System.Collections.Generic;
using AspCoreWebApp.Entities.Models;

namespace AspCoreWebApp.Business.Abstract
{
    public interface IDepartmanService
    {
        List<Departman> GetAllDepartmans();

        Departman GetDepartmanById(int id);

        Departman CreateDepartman(Departman departman);

        Departman UpdateDepartman(Departman departman);
        
        void DeleteDepartman(int id);
        
    }
}