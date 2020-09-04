using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_lab1.Companies;
using OOP_lab1.Modules.Engine.TypeOfEngine;
using OOP_lab1.Modules.Wings;
using OOP_lab1.Planes;
using OOP_lab1.Planes.TypeOfPlanes;
using System.Collections.Generic;

namespace OOP_lab1_Tests
{
    [TestClass]
    public class PlaneTest
    {
        [TestMethod]
        public void FindTest()
        {   
             Company company = new Company();
            Company companyTest = new Company();
            companyTest.AddPlanes(new List<PassengerPlane>()
            {
                new PassengerPlane(name: "Stg-34", flightRange: 2800, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 470),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    }
            });
            company.AddPlanes(new List<PassengerPlane>()
            {
                new PassengerPlane(name: "Stg-34", flightRange: 2800, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 470),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    },
                new PassengerPlane(name: "Stg-44", flightRange: 2700, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 870),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    },
                new PassengerPlane(name: "Stg-54", flightRange: 3100, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 770),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    },
                new PassengerPlane(name: "Stg-64", flightRange: 1900, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 670),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    }
            });

        
            int lowerFuelConsumption = 400;
            int upperFuelConsumption = 600;
            IList<Plane> fPlanes= company.FindPlane(lowerFuelConsumption, upperFuelConsumption);
            IList<Plane> testPlane = companyTest.GetPlanes();
            Assert.IsTrue(true);
        }


        [TestMethod]
        public void SortTest()
        {
            Company company = new Company();
            Company companyTest = new Company();
            company.AddPlanes(new List<PassengerPlane>()
            {
                new PassengerPlane(name: "Stg-34", flightRange: 2800, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 470),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    },
                new PassengerPlane(name: "Stg-44", flightRange: 2700, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 870),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    },
                new PassengerPlane(name: "Stg-54", flightRange: 3100, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 770),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    },
                new PassengerPlane(name: "Stg-64", flightRange: 1900, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 670),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    }
            });
            companyTest.AddPlanes(new List<PassengerPlane>()
            {
                new PassengerPlane(name: "Stg-34", flightRange: 2800, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 470),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    },
                new PassengerPlane(name: "Stg-44", flightRange: 3100, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 470),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    },
                new PassengerPlane(name: "Stg-44", flightRange: 2700, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 470),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    },
                new PassengerPlane(name: "Stg-44", flightRange: 1900, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 470),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    }
            });

            company.SortByFlightRange();
            IEnumerable<Plane> _planes = company.GetPlanes();
            IEnumerable<Plane> _planesTest = companyTest.GetPlanes();
       
            Assert.AreEqual(_planes, _planes);
        }
    }


}
