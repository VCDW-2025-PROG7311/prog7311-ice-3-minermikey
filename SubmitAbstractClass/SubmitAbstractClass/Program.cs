
using SubmitAbstractClass.Factories;
using SubmitAbstractClass.Interfaces;

class Program
{
    static void Main()
    {
        // calling in the factory 
        IUIFactory factory;

        // Choose Theme
        Console.WriteLine("Choose Theme: (1) Light Mode, (2) Dark Mode");
        string choice = Console.ReadLine();

        if (choice == "1")
            factory = new LightUIFactory();
        else
            factory = new DarkUIFactory();

        // Create UI Elements
        IButton button = factory.CreateButton();
        ITextBox textBox = factory.CreateTextBox();

        // Render UI Elements
        button.Render();
        textBox.Render();
    }
}
