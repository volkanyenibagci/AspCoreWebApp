using System;
using System.Collections.Generic;
using System.Linq;
using AspCoreWebApp.DataAccess.Abstract;
using AspCoreWebApp.Entities.Models;


namespace AspCoreWebApp.DataAccess.Concrete
{
    public class DepartmanRepository : IDepartmanRepository
    {
       
       
        public IEnumerable<Departman> GetAllDepartmans()
        {
            using (var aspCoreContext=new AspCoreContext())
            {
                return aspCoreContext.Departmans.ToList();
            }
           
           
        }

        public Departman GetDepartmanById(int id)
        {
            using (var aspCoreContext=new AspCoreContext())
            {
                return aspCoreContext.Departmans.Find(id);
            }
           
        }

        public Departman CreateDepartman(Departman departman)
        {
            using (var aspCoreContext=new AspCoreContext())
            {
                aspCoreContext.Departmans.Add(departman);
                aspCoreContext.SaveChanges();
                return departman;
            }
            
          
        }

        public Departman updateDepartman(Departman departman)
        {
            using (var aspCoreContext=new AspCoreContext())
            {
                aspCoreContext.Departmans.Update(departman);
                return departman;
            }
        }

        public void DeleteDepartman(int id)
        {
            using (var aspCoreContext=new AspCoreContext())
            {
                var deleteDepartman = GetDepartmanById(id);
                aspCoreContext.Departmans.Remove(deleteDepartman);
                aspCoreContext.SaveChanges();
            }
            
        }

        private bool disposed = false;  
        protected virtual void Dispose(bool disposing)  
        {  
            if (!this.disposed)  
            {  
                if (disposing)  
                {  
                    using (var aspCoreContext=new AspCoreContext())
                    {
                        aspCoreContext.Dispose(); 
                    }
                    
                }  
            }  
            this.disposed = true;  
        }  
        public void Dispose()  
        {  
            Dispose(true);  
            GC.SuppressFinalize(this);  
        }  
    }
}