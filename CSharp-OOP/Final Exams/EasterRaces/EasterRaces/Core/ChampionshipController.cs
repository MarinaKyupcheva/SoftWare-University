using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Core
{
    public class ChampionshipController : IChampionshipController
    {
        private readonly IRepository<IDriver> driverReposiroty;
        private readonly IRepository<ICar> carRepository;
        private readonly IRepository<IRace> raceRepository;
        public ChampionshipController()
        {
            this.driverReposiroty = new DriverRepository();
            this.carRepository = new CarRepository();
            this.raceRepository = new RaceRepository();
        }
        public string AddCarToDriver(string driverName, string carModel)
        {
            IDriver driver = this.driverReposiroty.GetByName(driverName);
            ICar car = this.carRepository.GetByName(carModel);

            if(driver == null)
            {
                throw new InvalidOperationException (string.Format (ExceptionMessages.DriverNotFound, driverName));
            }

            if(car == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.CarNotFound, carModel));
            }

            driver.AddCar(car);
            return string.Format(OutputMessages.CarAdded, driver.Name, car.Model);
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            IRace race = this.raceRepository.GetByName(raceName);
            IDriver driver = this.driverReposiroty.GetByName(driverName);

            if(race == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            if(driver == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }

            race.AddDriver(driver);
            return string.Format(OutputMessages.DriverAdded, driverName, raceName);
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            type = type + "Car";
            ICar car = null;

            if(type == "MuscleCar")
            {
                car = new MuscleCar(model, horsePower);
            }

            if(type == "SportsCar")
            {
                car = new SportsCar(model, horsePower);
            }

            this.carRepository.Add(car);
            return string.Format(OutputMessages.CarCreated, type, model);
        }

        public string CreateDriver(string driverName)
        {
            IDriver driver = new Driver(driverName);

            this.driverReposiroty.Add(driver);

            return string.Format(OutputMessages.DriverCreated, driverName);
        }

        public string CreateRace(string name, int laps)
        {
            IRace race = new Race(name, laps);

            this.raceRepository.Add(race);

            return string.Format(OutputMessages.RaceCreated, name);
        }

        public string StartRace(string raceName)
        {
            IRace race = this.raceRepository.GetByName(raceName);

            if(race == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

           if(race.Drivers.Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceInvalid, raceName, 3));
            }

            IDriver[] winners = race.Drivers
                .OrderByDescending(x => x.Car.CalculateRacePoints(race.Laps)).Take(3).ToArray();

            this.raceRepository.Remove(race);

            return string.Format(OutputMessages.DriverFirstPosition, winners[0].Name, raceName) +
                Environment.NewLine +
                    string.Format(OutputMessages.DriverSecondPosition, winners[1].Name, raceName) +
                    Environment.NewLine +
                    string.Format(OutputMessages.DriverThirdPosition, winners[2].Name, raceName);
                    

        }
    }
}
