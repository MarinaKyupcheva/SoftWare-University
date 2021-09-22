using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private  List<IComponent> components;
        private  List<IPeripheral> peripherals;
             
        public Computer(int id, string manufacturer, string model, decimal price, double overallPerformance) 
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
           
        }

        public IReadOnlyCollection<IComponent> Components => components.AsReadOnly();

        public IReadOnlyCollection<IPeripheral> Peripherals => peripherals.AsReadOnly();

        public override decimal Price
        {
            get 
            {
               return base.Price + this.components.Sum(x => x.Price) + this.peripherals.Sum(x => x.Price);
            }

        }

        public override double OverallPerformance
        {
            get
            
            { 
                if(this.components.Count == 0)
                {
                    return base.OverallPerformance;
                }

                else
                {
                    return base.OverallPerformance + this.components.Average(x => x.OverallPerformance);
                }
            }

        }

        public void AddComponent(IComponent component)
        {
            var existingComponent = components.FirstOrDefault(x => x.GetType().Name == component.GetType().Name);

            if (existingComponent != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingComponent,
                    component.GetType().Name, this.GetType().Name, this.Id));
            }

            this.components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            var existingPerpheral = this.peripherals.FirstOrDefault(x => x.GetType().Name == peripheral.GetType().Name);

            if(existingPerpheral != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingPeripheral,
                    existingPerpheral.GetType().Name, this.GetType().Name, this.Id));
            }

            this.peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            var existingComponent = this.components.FirstOrDefault(x => x.GetType().Name == componentType);

            if(this.components.Count == 0 || existingComponent == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingComponent,
                    existingComponent.GetType().Name, this.GetType().Name, this.Id));
            }

            this.components.Remove(existingComponent);
            return existingComponent;

        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            var existingPeripheral = this.peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);

            if(this.peripherals.Count== 0 || existingPeripheral == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingPeripheral,
                    existingPeripheral.GetType().Name, this.GetType().Name, this.Id));
            }

            this.peripherals.Remove(existingPeripheral);
            return existingPeripheral;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine (base.ToString());

            sb.AppendLine($" Components ({this.components.Count}):");
            if(this.components.Count > 0)
            {
                foreach (var component in components)
                {
                    sb.AppendLine($"  {component}");
                }
            }
            double performance = peripherals.Count > 0 ? this.peripherals.Average(x => x.OverallPerformance) : 0;
        sb.AppendLine($" Peripherals ({peripherals.Count}); " +
                $"Average Overall Performance ({performance:F2}):");

            if(this.peripherals.Count > 0)
            {
                foreach (var peripheral in peripherals)
                {
                    sb.AppendLine($"  {peripheral}");
                }
            }
            return sb.ToString().TrimEnd();           
        }
    }
}
