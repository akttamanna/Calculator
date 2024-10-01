CalculatorApp();

static void CalculatorApp()

{
    // Declare the variables and initialise them to 0.

    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    // Ask the user to type the first number.

    Console.WriteLine("Type in the first number followed by the Enter key");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    // Ask the user to type the second number.

    Console.WriteLine("Type in the second number followed by the Enter key");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    // Use a loop to make the relevant decision and perfrom the request maths
    // operations

    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Substract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");
    // Convert string to integer

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1){
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} equal {result}");

    }else if (choice == 2){
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {firstNumber} from {secondNumber} equal {result}");

    }else if (choice == 3){
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} by {secondNumber} equal {result}");

    }else if (choice == 4){
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} by {secondNumber} equal {result}");
    }

    else{
        Console.WriteLine("You did not select a valid number between 1-4");
    }

    // Perform the calculation

    // result = firstNumber + secondNumber;

    // Output the answer to the console

    // Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber,
    // secondNumber, result); 
}


