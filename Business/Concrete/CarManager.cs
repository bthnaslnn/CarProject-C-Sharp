using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal carDal)
        {
            _cardal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length>2)
            {
                _cardal.Add(car);
            }
            else
            {
                Console.WriteLine("Girdiğiniz araç ismi 2 karakterden fazla olmamalıdır.");
            }
        }

        public void Delete(Car car)
        {
            _cardal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _cardal.GetAll(p=>p.BrandId==id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _cardal.GetAll(p=>p.ColorId==id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _cardal.GetAll(p=>p.DailyPrice>=min && p.DailyPrice<=max);
        }

        public Car GetById(int Carid)
        {
            return _cardal.Get(c => c.CarId == Carid);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _cardal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _cardal.Update(car);
        }
    }
}
