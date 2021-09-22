using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories
{
    public class CarRepository : IRepository<ICar>
    {
        private readonly IDictionary<string, ICar> carsByName;

        public CarRepository()
        {
            carsByName = new Dictionary<string, ICar>();
        }
        public void Add(ICar model)
        {

            if (this.carsByName.ContainsKey(model.Model))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CarExists, model.Model));
            }

            carsByName.Add(model.Model, model);
        }

        public IReadOnlyCollection<ICar> GetAll()
        {
            return this.carsByName.Values.ToList();
        }

        public ICar GetByName(string name)
        {
            ICar car = null;
            if (this.carsByName.ContainsKey(name))
            {
                car = this.carsByName[name];
            }

            return car;
        }

        public bool Remove(ICar model)
        {
           return this.carsByName.Remove(model.Model);
        }
    }
}
