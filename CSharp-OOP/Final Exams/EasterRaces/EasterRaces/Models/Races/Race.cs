using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Models.Races
{
    public class Race : IRace
    {
        private string name;
        private int laps;
        private readonly IDictionary<string, IDriver> driversByName;

        public Race(string name, int laps)
        {
            driversByName = new Dictionary<string, IDriver>();
            this.Name = name;
            this.Laps = laps;
        }
        public string Name 
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length< 5)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, 5));
                }

                this.name = value;
            }
        }
        public int Laps
        {
            get => this.laps;
            private set
            {
                if(value < 1)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidNumberOfLaps, 1));
                }

                this.laps = value;
            }
        }

        public IReadOnlyCollection<IDriver> Drivers => driversByName.Values.ToList();

        public void AddDriver(IDriver driver)
        {
            if(driver == null)
            {
                throw new ArgumentNullException(ExceptionMessages.DriverInvalid);
            }

            if (!driver.CanParticipate)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriverNotParticipate, driver.Name));
            }

            if (this.driversByName.ContainsKey(driver.Name))
            {
                throw new ArgumentNullException
                    (string.Format(ExceptionMessages.DriverAlreadyAdded, driver.Name, this.Name));
            }

            this.driversByName.Add(driver.Name, driver);
        }
    }
}
