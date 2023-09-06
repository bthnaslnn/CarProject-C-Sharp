using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        CarTest();
        GetCarDetailsTest();
        GetAllCustomerTest();
        GetAllRentalTest();
        

        
    }
    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());
        var result = carManager.GetAll();

        if (result.Success)
        {
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName + "/" + car.ModelYear);
                
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }

    }

    private static void GetCarDetailsTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());
        var result = carManager.GetCarDetails();

        if (result.Success)
        {
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName);

            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }

    }
    private static void GetAllCustomerTest()
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        var result = customerManager.GetAll();
        if (result.Success)
        {
            foreach (var customer in result.Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }
    private static void GetAllRentalTest()
    {
        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        var result = rentalManager.GetAll();
        if (result.Success)
        {
            foreach (var rental in result.Data)
            {
                Console.WriteLine(rental.RentDate);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }
}