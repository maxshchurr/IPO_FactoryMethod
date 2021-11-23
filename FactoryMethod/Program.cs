using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        /*   все виды курьеров
        
        enum CourierType
        {
            PedastrianCourier,
            CarCourier
        }

    */

        public interface ICourier
        {
            void TakeOrder();
            void FinishOrder();
            void Info();
        }

        class CarCourier : ICourier
        {
            public int speed = 45;
            public int price = 50;

            public void TakeOrder()
            {
                Console.WriteLine("CarCourier took this order");
            }

            public void FinishOrder()
            {
                Console.WriteLine("CarCourier finished this order");
            }

            public void Info()
            {
                Console.WriteLine($"CarCourier speed is {speed}km/h and price is {price}UAH");
            }
        }
        class PedastrianCourier : ICourier
        { 
            public int speed = 5;
            public int price = 20;
        
            public void TakeOrder()
            {
                Console.WriteLine("PedastrianCourier took this order");
            }
            public void FinishOrder()
            {
                Console.WriteLine("PedastrianCourier finished this order");
            }

            public void Info()
            {
                Console.WriteLine($"PedastrianCourier speed is {speed}km/h and price is {price}UAH");
            }
        }

        interface ICourierMeneger
        {
            
            ICourier GetCourier();

        }

        class CarCourierMeneger : ICourierMeneger
        {       
            public ICourier GetCourier()
            {
                return new CarCourier();
            }
        }

        class PedCourierMeneger : ICourierMeneger
        {
            public ICourier GetCourier()
            {
                return new PedastrianCourier();
            }

        }

        // Client code

        static void Main(string[] args)
        {
            

            ICourierMeneger ped_meneger = new PedCourierMeneger();
            ICourierMeneger car_meneger = new CarCourierMeneger();
            ICourier c1 = car_meneger.GetCourier();
            c1.Info();
            c1.TakeOrder();
            c1.FinishOrder();

            Console.ReadLine();
        }

    }

}
