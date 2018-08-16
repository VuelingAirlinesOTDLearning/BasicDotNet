﻿namespace BasicDotNet.VuelingAirlinesFleet
{
    public class Engine : IThrottable, IControllable
    {
        public string Maker {get; private set;}
        public string Model {get; private set;}
        public EngineType Type {get; private set;}
        public EngineState State {get; set;}
        protected int Impulsion{get; private set;}
        private const double NominalConsumption = 8.0;

        public Engine(string maker, string model, EngineType type)
        {
            Maker = maker;
            Model = model;
            Type = type;
        }

        public void Start() { }
        public void Stop() { }
        public void IncreaseImpulsion(){ ++Impulsion; }
        public void DecreaseImpulsion(){ --Impulsion; }

        public double FuelConsumption 
        {
            get
            {
                var engineTypeFactor = (Type == EngineType.Jet) ? 2.0 : 1.0;                
                return engineTypeFactor * NominalConsumption * Impulsion;
            }
        }
        public double AirspeedIncrement
        {
            get
            {
                return Type == EngineType.Jet ? 100.0 : 60.0; 
            }
        }
    }
}
