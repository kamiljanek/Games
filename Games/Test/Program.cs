using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck superDuck = new Duck(new NoQuack(), new FastFly(), new BigDisplay());
            superDuck.Quack();
            superDuck.Fly();
            superDuck.Display();
            Pearson john = new Pearson(new RunWalk(), new HugeAmountEat());
            john.Eat();
            john.Walk();
        }
    }
  
            //var kaczka = new Kaczka(new SzybkieLatanie());
        
    class Pearson
    {
        private IWalk walk;
        private IEat eat;
        public Pearson (IWalk walk, IEat eat)
        {
            this.walk = walk;
            this.eat = eat;
        }
       public void Walk()
        {
            this.walk.Walk();
        }
       public void Eat()
        {
            this.eat.Eat();
        }
    }
    interface IWalk
    {
        void Walk();
    }
    class RunWalk : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("Im running");
        }
    }
    class SlowWalk : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("Im normal walking");
        }
    }
    interface IEat
    {
        void Eat();
    }
    class HugeAmountEat : IEat
    {
        public void Eat()
        {
            Console.WriteLine("I have whole table full of food");
        }
    }
    class SmallAmountEat : IEat
    {
        public void Eat()
        {
            Console.WriteLine("I have only banana");
        }
    }
    class Duck
    {
        private IQuackBehaviour quackBehaviour;
        private IFlyBehaviour flyBehaviour;
        private IDisplayBehaviour displayBehaviour;
        public Duck(IQuackBehaviour qb, IFlyBehaviour fb, IDisplayBehaviour db)
        {
            quackBehaviour = qb;
            flyBehaviour = fb;
            displayBehaviour = db;
        }
        public void Quack()
        {
            quackBehaviour.Quack();
        }
        public void Fly()
        {
            flyBehaviour.Fly();
        }
        public void Display()
        {
            displayBehaviour.Display();
        }
    }

    interface IQuackBehaviour
    {
        void Quack();
    }
    class SimpleQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("SimpleQuack");  
        }
    }
    class NoQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("NoQuack");
        }
    }

    interface IFlyBehaviour
    {
        void Fly();
    }
    class SlowFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("SlowFly");
        }
    }
    class FastFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("FastFly");
        }
    }
    interface IDisplayBehaviour
    {
        void Display();
    }
    class BigDisplay : IDisplayBehaviour
    {
        public void Display()
        {
            Console.WriteLine("BigDisplay");
        }
    }
    class SmallDisplay : IDisplayBehaviour
    {
        public void Display()
        {
            Console.WriteLine("SmallDisplay");
        }
    }

    //interface ILatanie
    //{

    //    void Lec();
    //}
    //class SzybkieLatanie : ILatanie
    //{
    //    public void Lec()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class PowolneLatanie : ILatanie
    //{
    //    public void Lec()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Kaczka
    //{
    //    private ILatanie latanie;

    //    public Kaczka(ILatanie latanie)
    //    {
    //        this.latanie = latanie;
    //    }
    //}
}
