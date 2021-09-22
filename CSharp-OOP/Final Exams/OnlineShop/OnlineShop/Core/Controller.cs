using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IComponent = OnlineShop.Models.Products.Components.IComponent;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private List<IComputer> computers;
        private List<IComponent> components;
        private List<IPeripheral> peripherals;

        public Controller()
        {
            this.computers = new List<IComputer>();
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }
        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            var computer = this.computers.FirstOrDefault(x => x.Id == computerId);

            if(computer == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }

            IComponent component = null;

            if(this.components.Any(x=>x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
            }

            if(componentType == "CentralProcessingUnit")
            {
                component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
                this.components.Add(component);
            }
            else if (componentType == "Motherboard")
            {
                component = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
                this.components.Add(component);
            }
            else if (componentType == "PowerSupply")
            {
                component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
                this.components.Add(component);
            }
            else if (componentType == "RandomAccessMemory")
            {
                component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
                this.components.Add(component);
            }
            else if (componentType == "SolidStateDrive")
            {
                component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
                this.components.Add(component);
            }
            else if (componentType == "VideoCard")
            {
                component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
                this.components.Add(component);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComponentType);
            }

            return string.Format(SuccessMessages.AddedComponent, componentType, component.Id, computer.Id);
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {

            if (computers.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComputerId);
            }

            if (computerType == "DesktopComputer")
            {
                computers.Add(new DesktopComputer(id, manufacturer, model, price));
            }
            if (computerType == "Laptop")
            {
                computers.Add(new Laptop(id, manufacturer, model, price));
            }

            if(computerType != "DesktopComputer" && computerType != "Laptop")
            {
                throw new ArgumentException(ExceptionMessages.InvalidComputerType);
            }


            return $"Computer with id {id} added successfully.";
        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {
            var computer = this.computers.FirstOrDefault(x => x.Id == computerId);

            if (computer == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }

            IPeripheral peripheral = null;

            if(this.peripherals.Any(x=>x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
            }

            if(peripheralType == "Headset")
            {
                peripheral = new Headset(id, manufacturer, model, price, overallPerformance, connectionType);
                computer.AddPeripheral(peripheral);
                this.peripherals.Add(peripheral);
            }
            else if (peripheralType == "Keyboard")
            {
                peripheral = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);
                computer.AddPeripheral(peripheral);
                this.peripherals.Add(peripheral);
            }
            else if (peripheralType == "Monitor")
            {
                peripheral = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);
                computer.AddPeripheral(peripheral);
                this.peripherals.Add(peripheral);
            }
            else if (peripheralType == "Mouse")
            {
                peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);
                computer.AddPeripheral(peripheral);
                this.peripherals.Add(peripheral);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidPeripheralType);
            }

            return string.Format(SuccessMessages.AddedPeripheral, peripheralType, peripheral.Id, computer.Id);
        }

        public string BuyBest(decimal budget)
        {
            var computer = this.computers.OrderByDescending(x => x.OverallPerformance)
                .FirstOrDefault(x => x.Price <= budget);

            if(computer == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CanNotBuyComputer, budget));
            }

            this.computers.Remove(computer);
            return computer.ToString();
        }

        public string BuyComputer(int id)
        {
            var computer = this.computers.FirstOrDefault(x => x.Id == id);

            if (computer == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
            
                computers.Remove(computer);

                return computer.ToString();
            
            
        }

        public string GetComputerData(int id)
        {
            var computer = this.computers.FirstOrDefault(x => x.Id == id);

            if (computer == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
            return computer.ToString();

        }

        public string RemoveComponent(string componentType, int computerId)
        {
            var computer = this.computers.FirstOrDefault(x => x.Id == computerId);

            if (computer == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }

            var component = computer.Components.FirstOrDefault(x => x.GetType().Name == componentType);

            if (component == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingComponent,
                    componentType, computer.GetType().Name, computerId));
            }

            computer.RemoveComponent(componentType);
            this.components.Remove(component);

            return string.Format(SuccessMessages.RemovedComponent, componentType, component.Id);

        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            var computer = this.computers.FirstOrDefault(x => x.Id == computerId);

            if (computer == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }

            var peripheral = computer.Peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);

            if(peripheral == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingPeripheral,
                    peripheralType, computer.GetType().Name, computerId));
            }

            computer.RemovePeripheral(peripheralType);
            this.peripherals.Remove(peripheral);

            return string.Format(SuccessMessages.RemovedPeripheral, peripheralType, peripheral.Id);
        }
    }
}
