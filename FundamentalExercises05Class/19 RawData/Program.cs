using System;
using System.Collections.Generic;

namespace _19_RawData
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Car
    {
        public string Model { get; set; }
        private List<Engine> engine;    
        public List<Engine> Engine 
        {
            get { return engine; }
            set { engine = value; } 
        }
        private List<Cargo> cargo;
        public List<Cargo> Cargo 
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public Car()
        {
            this.Engine = new List<Engine>();
            this.Cargo = new List<Cargo>();
        }


}

    public class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }

    public class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
