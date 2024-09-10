
# Technology Store Inventory Management

Welcome to the Technology Store Inventory Management project! This project demonstrates the use of object-oriented programming principles in C# including inheritance, encapsulation, polymorphism, and abstraction. The application manages two types of products: `Phone` and `Computer`, both inheriting from a base class `BaseMachine`.

## Project Overview

### Base Class: `BaseMachine`

The `BaseMachine` class serves as the base class for all machines and includes:

- **Properties:**
  - `ProductionDate`: The date of production, automatically set to the current date when an object is created.
  - `SerialNumber`: A unique identifier for the machine.
  - `Name`: The name of the machine.
  - `Description`: A brief description of the machine.
  - `OperatingSystem`: The operating system installed on the machine.

- **Methods:**
  - `DisplayInformation()`: Prints common information about the machine, including production date, serial number, name, description, and operating system. This method is overridden in derived classes to include specific details.
  - `GetProductName()`: An abstract method to be implemented by derived classes to print a message with the product's name.

### Derived Classes

#### Class: `Phone`

The `Phone` class inherits from `BaseMachine` and includes additional properties:

- **Properties:**
  - `IsTRLicensed`: A boolean indicating whether the phone is licensed in Turkey.

- **Methods:**
  - `DisplayInformation()`: Overrides the base class method to include `IsTRLicensed` information.
  - `GetProductName()`: Implements the abstract method to print the phone's name.

#### Class: `Computer`

The `Computer` class also inherits from `BaseMachine` and includes additional properties:

- **Properties:**
  - `USBPortCount`: The number of USB ports, limited to 2 or 4. Any other value will trigger a warning and set the value to -1.
  - `HasBluetooth`: A boolean indicating whether the computer has Bluetooth.

- **Methods:**
  - `DisplayInformation()`: Overrides the base class method to include `USBPortCount` and `HasBluetooth` information.
  - `GetProductName()`: Implements the abstract method to print the computer's name.

## Program Flow

1. **User Input:**
   - The user is prompted to enter `1` to create a Phone or `2` to create a Computer.

2. **Data Collection:**
   - Based on the user's choice, the program creates an instance of the selected class and collects product details from the user.

3. **Confirmation:**
   - Once all details are entered, the program confirms the successful creation of the product and asks if the user wants to create another product.

4. **Repeat or Exit:**
   - If the user chooses to create another product, the program returns to the initial prompt. If the user opts to exit, the program bids farewell and terminates.


### Explanation

- **Inheritance**: `Phone` and `Computer` classes inherit from `BaseMachine`.
- **Encapsulation**: The `USBPortCount` property in `Computer` class only allows values of 2 or 4.
- **Polymorphism**: The `DisplayInformation()` method is overridden in derived classes to add specific details.
- **Abstraction**: The `GetProductName()` method is abstract in `BaseMachine` and implemented differently in each derived class.

## How to Run the Project

1. **Install Visual Studio:**
   - Download and install [Visual Studio](https://visualstudio.microsoft.com/) or any compatible C# IDE.

2. **Ensure .NET SDK is Installed:**
   - Verify that the [.NET SDK](https://dotnet.microsoft.com/download) is installed on your system.

3. **Clone or Download the Repository:**
   - Clone the repository or download the project files to your local machine.

4. **Open the Project:**
   - Open the project in Visual Studio by loading the `.sln` file or by opening the project folder.

5. **Run the Program:**
   - Execute the program using the shortcut `Ctrl + F5` or through the terminal command:
     ```bash
     dotnet run
     ```

6. **Interact with the Application:**
   - Follow the console prompts to create new products and view their details.

## Technologies Used

- **C#**: The programming language used for developing the classes and application logic.
- **.NET Core**: The framework used for compiling and running the C# code.
- **Visual Studio**: The IDE used for writing and running the code.

## Contribution

This project is intended for educational purposes. Contributions are not required but feedback and suggestions are welcome.

## License

This project is for educational use and does not require a specific license.

![image](https://github.com/user-attachments/assets/c2a4cdb0-3503-4970-ba7c-677797cfd370)
