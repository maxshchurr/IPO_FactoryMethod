using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Client close_client = new Client(new PedastrianMeneger());
            Client far_client = new Client(new TransportMeneger());

            close_client.MakeOrder();
            close_client.Pay();

            far_client.MakeOrder();
            far_client.Pay();

            Console.ReadLine();
        }
    }
    abstract class Courier
    {
        public abstract void TakeOrder();
        public abstract void FinishOrder();
    }

    class MotoCourier : Courier
    {
        public override void TakeOrder()
        {
            Console.WriteLine("MotoCourier took this order.");
        }

        public override void FinishOrder()
        {
            Console.WriteLine("MotoCourier finished his order.He is cleaning his Motocycle to be ready for the next order.");
        }
    }

    class PedastrianCourier : Courier
    {
        public override void TakeOrder()
        {
            Console.WriteLine("PedastrianCourier took this order");
        }

        public override void FinishOrder()
        {
            Console.WriteLine("PedastrianCourier finished his order.He needs a rest to be ready for the next order.");
        }
    }

    abstract class Meneger
    {
        public abstract Courier CreateCourier();
    }

    class PedastrianMeneger : Meneger
    {
        public override Courier CreateCourier()
        {
            return new PedastrianCourier();
        }
    }

    class TransportMeneger : Meneger
    {
        public override Courier CreateCourier()
        {
            return new MotoCourier();
        }
    }

    class Client
    {
        private Courier Courier;

        public Client(Meneger meneger)
        {
            Courier = meneger.CreateCourier();          
        }

        public void MakeOrder()
        {
            Courier.TakeOrder();
        }

        public void Pay()
        {
            Courier.FinishOrder();
        }
    }

   
}


    

