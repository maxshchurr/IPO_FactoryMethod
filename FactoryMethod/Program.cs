using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        interface ICourier
        {
            void TakeOrder();
            void FinishOrder();
            void Info();
        }

        class CarCourier : ICourier
        {
            private int Speed = 40;
            private int Capacity = 60;
            private int Price = 50;

            public void Info()
            {
                Console.WriteLine($"CarCourier speed is {Speed}km/h,available capacity is {Capacity}kg and price is {Price}UAH.");
            }
            public void TakeOrder()
            {
                Console.WriteLine("CarCourier took this order");
            }
            public void FinishOrder()
            {
                Console.WriteLine("CarCourier finished this order");
            }
        }

        class PedastrianCourier : ICourier
        {
            private int Speed = 5;
            private int Capacity = 15;
            private int Price = 20;

            public void Info()
            {
                Console.WriteLine($"PedastrianCourier speed is {Speed}km/h,available capacity is {Capacity}kg and price is {Price}UAH.");
            }

            public void TakeOrder()
            {
                Console.WriteLine("PedastrianCourier took this order");
            }

            public void FinishOrder()
            {
                Console.WriteLine("PedastrianCourier finished this order");
            }
        }

        interface IMeneger
        {
            ICourier CreateCourier();
        }

        class CarMeneger : IMeneger
        {
            public ICourier CreateCourier()
            {
                return new CarCourier();
            }
        }

        class PedMeneger : IMeneger
        {
            public ICourier CreateCourier()
            {
                return new PedastrianCourier();
            }
        }
        static void Main(string[] args)
        {
            // creating menegers
            IMeneger car_men = new CarMeneger();
            IMeneger ped_men = new PedMeneger();


            ICourier car_courier1 = car_men.CreateCourier();
            ICourier pedastrian_courier1 = ped_men.CreateCourier();

            car_courier1.Info();
            car_courier1.TakeOrder();
            car_courier1.FinishOrder();
            
            
            pedastrian_courier1.Info();


            Console.ReadLine();
        }

    }
}

    

