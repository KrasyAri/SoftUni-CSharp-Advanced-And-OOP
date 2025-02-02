﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

       
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        
        public void Drive(double amountKm)
        {
            bool canMove = FuelAmount - (amountKm * FuelConsumptionPerKilometer) >=0;

            if (canMove)
            {
                FuelAmount -= amountKm * FuelConsumptionPerKilometer;
                TravelledDistance += amountKm;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }

        public string WhoAmI()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}";
            
        }
    }
}
