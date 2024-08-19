using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Final
{
    public abstract class BaseDevice
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        public DateTime ProductionDate { get; set; }
       
        public BaseDevice() {
            ProductionDate = DateTime.Now;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Production Time {ProductionDate} \nSerial Number: {SerialNumber} \nName: {Name} \nDescription: {Description} \nOperating System: {OperatingSystem}");
        }
        public abstract string GetDeviceName();
    }

    public class CellPhone : BaseDevice
    {
        public bool IsPhoneTRLicance { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Tr Licance: " + IsPhoneTRLicance);
        }

        public override string GetDeviceName()
        {
            return "Cellphone Name --->" + Name;
            
        }

    }

    public class Computer : BaseDevice
    {
        private int usbPortCount;
        public int UsbPortCount
        {
            get { return usbPortCount; }
            set
            {
                if (value == 2 || value == 4)
                {
                    usbPortCount = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Warning!: Invalid USB port count. Defaulting to -1.");
                    Console.ResetColor();
                    usbPortCount = -1;
                }
            }
        }
        public bool IsComputerBluetooth { get; set; }

        public override string GetDeviceName()
        {
            return "Computer Name ---> " + Name;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Usb Port Count: " + usbPortCount +"\nBluetooth: " + IsComputerBluetooth);
        }

    }

}
