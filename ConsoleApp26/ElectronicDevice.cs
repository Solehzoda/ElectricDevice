using System;
namespace ConsoleApp26
{
    public class ElectronicDevice
    {
        private string Brand;
        protected int BatteryLevel;
        private bool IsOn;

        public string GetBrand
        {
            get { return Brand; }
            set { Brand = value; }
        }

        public int GetBatteryLevel
        {
            get { return BatteryLevel; }
            set { BatteryLevel = value; }
        }

        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
        }

        public void AddBatteryLevel(int level)
        {
            BatteryLevel += level;
            if (BatteryLevel > 100) BatteryLevel = 100;
            Console.WriteLine($"This {Brand} is now {BatteryLevel}");
            {
                
            }
        }
               
            }
        }

