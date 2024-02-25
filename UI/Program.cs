using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
   class Program
    {
        static void Main(string[] args) {
        
            Car car=new Car() {Id=4,BrandId=2,ColorId=2,DailyPrice=242424242,Description="Renault",ModelYear=2009 };
            CarManager carManager=new CarManager(new InMemoryCarDal());
            carManager.Add(car);
            //carManager.Delete(car);
            //carManager.Update(car);
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            //
            foreach (var item in carManager.GetById(2))
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
