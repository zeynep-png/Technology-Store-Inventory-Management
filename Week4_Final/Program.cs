
using System.ComponentModel.Design;
using Week4_Final;
while (true)
{
que: Console.WriteLine("\nPlease select the device you want to produce. \n\n--Press 1 for CellPhone \n--Press 2 for Computer");
    int input = Convert.ToInt32(Console.ReadLine());

    if (input == 1)
    {
        CellPhone cellPhone = new CellPhone();

        Console.WriteLine("-What is the serial number of the phone?");
        cellPhone.SerialNumber = Console.ReadLine();

        Console.WriteLine("-What is the name of the phone?");
        cellPhone.Name = Console.ReadLine();
        Console.WriteLine("-What is the description of the phone?");
        cellPhone.Description = Console.ReadLine();
        Console.WriteLine("-What is the operating system of the phone?");
        cellPhone.OperatingSystem = Console.ReadLine();
        Console.WriteLine("-Does the phone have a Tr licese? (y/n)");
        string selection = Console.ReadLine();

        if (selection == "y")
            cellPhone.IsPhoneTRLicance = true;
        else
            cellPhone.IsPhoneTRLicance = false;

        cellPhone.GetDeviceName();
        cellPhone.ShowInfo();


    }
    else if (input == 2)
    {
        Computer computer = new Computer();

        Console.WriteLine("-What is the serial number of the computer?");
        computer.SerialNumber = Console.ReadLine();

        Console.WriteLine("-What is the name of the computer?");
        computer.Name = Console.ReadLine();
        Console.WriteLine("-What is the description of the computer?");
        computer.Description = Console.ReadLine();
        Console.WriteLine("-What is the operating system of the computer?");
        computer.OperatingSystem = Console.ReadLine();
        Console.WriteLine("-How many usb ports the computer have?");
        computer.UsbPortCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-Does the computer have bluetooth? (y/n)");
        string answ = Console.ReadLine();

        if (answ == "y")
            computer.IsComputerBluetooth = true;
        else
            computer.IsComputerBluetooth = false;
        computer.GetDeviceName();
        computer.ShowInfo();

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("----------!!!Invalid input!!!----------");
        Console.ResetColor();
        goto que;
    }
    Console.WriteLine("\n\nDevice production successful. Would you like to produce another device ? (y/n)");
    string main = Console.ReadLine();
    if (main == "y")
        goto que;
    else { 
        Console.WriteLine("\n\nHave a nice day!");
    break;
}
        
}
