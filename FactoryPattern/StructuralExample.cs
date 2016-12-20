using System;
using System.Collections.Generic;
using static System.Console;

namespace FactoryPattern
{
    abstract class Light//Product
    {
        public abstract Light TurnOn();
        public abstract Light TurnOff();
    }

    class BulbLight : Light//Concrete product
    {
        public override Light TurnOff()
        {
            WriteLine("Bulb Light is turned off");
            return this;
        }

        public override Light TurnOn()
        {
            WriteLine("Bulb Light is turned on");
            return this;
        }
    }

    class TubeLight : Light//Concrete product
    {
        public override Light TurnOff()
        {
            WriteLine("Tube Light is turned off");
            return this;
        }

        public override Light TurnOn()
        {
            WriteLine("Tube Light is turned on");
            return this;
        }
    }

    abstract class Creator
    {
        public abstract Light Factory();
    }

    class BulbCreator : Creator
    {
        public override Light Factory()
        {
            return new BulbLight();
        }
    }

    class TubeCreator : Creator
    {
        public override Light Factory()
        {
            return new TubeLight();
        }
    }
}
