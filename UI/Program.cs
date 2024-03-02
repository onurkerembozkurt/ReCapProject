﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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

          

            CarManager carManager=new CarManager(new InMemoryCarDal());   

            foreach (var item in carManager.GetDetail().Data)
            {
               Console.WriteLine(item.CarName + " " + item.BrandName + " " + " " + item.ColorName+" "+item.RentDate+" "+item.ReturnDate);
            }

        }
    }
}
