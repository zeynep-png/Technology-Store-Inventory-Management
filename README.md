# Technology Store Management System

## Overview

This project is a console application designed to manage records of phones and computers in a technology store. It utilizes Object-Oriented Programming (OOP) principles such as inheritance, encapsulation, polymorphism, and abstraction.

## OOP Principles Implemented

### 1. Classes and Objects

- **BaseDevice** class serves as the base class.
- **Phone** and **Computer** classes inherit from **BaseDevice**.

### 2. Encapsulation

- **Computer** class encapsulates the USB input count:
  - USB input count can only be set to 2 or 4. Otherwise, a warning message is shown and the value is set to -1.

### 3. Inheritance

- **Phone** and **Computer** classes inherit common properties from the **BaseDevice** class:
  - Properties include ProductionDate, SerialNumber, Name, Description, and OperatingSystem.

### 4. Polymorphism

- The **BaseDevice** class includes a `PrintInformation()` method to print common information.
- **Phone** and **Computer** classes override this method to include specific information.

### 5. Abstraction

- **BaseDevice** class defines an abstract method `GetProductName()`.
- **Phone** and **Computer** classes implement this method to print specific messages:
  - For **Phone**: `"Your phone's name ---> ......"`
  - For **Computer**: `"Your computer's name ---> ......"`

## Program Flow

1. **User Prompt**:
   - The console prompts the user to press `1` to create a phone or `2` to create a computer.

2. **User Selection**:
   - Based on the user's choice, the program creates an object of the corresponding class.
   - The program collects the properties of the selected product from the user via the console.

3. **Confirmation**:
   - After entering all details, the program confirms successful product creation.
   - The user is asked if they want to create another product.

4. **Continuation or Exit**:
   - If the user chooses `Yes`, the program returns to the first step.
   - If the user chooses `No`, the program ends with a farewell message.

## Usage

Run the application in a console environment. Follow the prompts to enter details for either a phone or a computer, and manage your product records effectively.

![image](https://github.com/user-attachments/assets/c2a4cdb0-3503-4970-ba7c-677797cfd370)
