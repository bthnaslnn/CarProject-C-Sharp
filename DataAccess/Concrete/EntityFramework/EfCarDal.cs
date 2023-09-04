using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        //Burada tabloları birleştirerek listelendiği zaman
        //gözükmnesini istediğimiz şekidle listeledik ve şartladık.
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext carContext = new CarContext()) 
            {
                var result = from c in carContext.Cars
                             join b in carContext.Brands
                                 on c.BrandId equals b.BrandId
                             join co in carContext.Colors
                                 on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                             };
                return result.ToList();

            }
        }
    }
}
