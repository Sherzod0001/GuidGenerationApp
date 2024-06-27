> # GuidGenerationApp

### Welcome to the GUID Generator!
----------------------------------------

## This project is a simple console program to generate a GUID (Globally Unique Identifier). The program generates a new GUID each time it is launched, copies it to the Clipboard, and displays it on the screen. After creating each new GUID, the program asks to continue.

> ### The project consists of two main methods:

1. Main - The starting point of the program. Codes are written to generate GUID, copy to Clipboard and interact with user.

2. ShowWelcomeMessage - Shows the user a welcome message about the program.

## Explanation of the code

Main Method
```cs
"""
static void Main(string[] args)
{
    ShowWelcomeMessage();

    string yesOrNo = "";
    do 
    {
        string StringGenerationGuid = Guid.NewGuid().ToString();

        Console.WriteLine($"New Guid: {StringGenerationGuid}");
        TextCopy.ClipboardService.SetText(StringGenerationGuid);
        Console.WriteLine("Copied....\n");

        Console.WriteLine("Do you want to continue? (yes / no)");
        yesOrNo = Console.ReadLine();
        Console.WriteLine();

    } while (yesOrNo.ToLower() == "yes" | yesOrNo.ToLower() == "y");

    Console.WriteLine("Thank you for using our program");
}

"""
```

- ShowWelcomeMessage() - This method displays the welcome message.

- string StringGenerationGuid = Guid.NewGuid().ToString(); - Creates a new GUID each time and stores it as a string.

- Console.WriteLine($"New Guid: {StringGenerationGuid}"); - Displays the generated GUID.  

- TextCopy.ClipboardService.SetText(StringGenerationGuid); - Copies the generated GUID to the Clipboard.

- Console.WriteLine("Copied....\n"); - Displays a message to indicate that it has been copied to the clipboard.

- yesOrNo = Console.ReadLine(); - Prompts the user for a response to continue or stop the program.

- do while - Repeats until the user answers 'yes' or 'y'. 

ShowWelcomeMessage Method

```cs
"""

static void ShowWelcomeMessage() 
{
    Console.WriteLine("Welcome to the project GUID Generator!!!");
    Console.WriteLine("Each time you type 'yes' or 'y', a new GUID is generated and copied to your clipboard\n");
}


"""

```

- Console.WriteLine(...) - Displays a welcome message to the console and how to use the program.

# Result to GIF

![result to gif](/gif/result%20to%20gif.gif)
 
> # Installation and Use

## Requirements

 - .NET SDK (https://dotnet.microsoft.com/download)

 - Visual Studio or Visual Studio Code (or another .NET editor)

 ## Clone a project

 1. Copy the GitHub repo URL.

 2. Open a Terminal or Git Bash window and enter the following commands:


 ```bash
git clone <repository_url>
cd <repository_folder>
 ```
 ## Build the project

 1. Go to the project folder in the terminal.

 2. Enter the following commands:

 ```bash
dotnet build
 ```
## Run the program

1. Go to the project folder in the terminal.

2. Enter the following commands:

```bash
dotnet run --project <project_name>
```

> ## Anyone can download this project on GitHub and run it on their computer.

> # We are glad you are using the program. 