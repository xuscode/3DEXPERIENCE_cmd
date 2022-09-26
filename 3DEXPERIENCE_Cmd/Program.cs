﻿
using System.Text;
using System.Drawing;

namespace Sharprompt.Example;

// ReSharper disable LocalizableElement
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            var type = Prompt.Select<CmdList>("Choose prompt list");

            switch (type)
            {
                case CmdList.Animation:
                    GeneratateAnimation.GeneratateAnimation.CATMain();
                    break;
                case CmdList.cmd2:

                  
                   
                    

                    break;
                case CmdList.cmd3:
                    RunPasswordSample();
                    break;
                case CmdList.cmd4:
                    RunSelectSample();
                    break;
              
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    private static void RunInputSample()
    {
        var name = Prompt.Input<string>("What's your name?", defaultValue: "John Smith", placeholder: "At least 3 characters", validators: new[] { Validators.Required(), Validators.MinLength(3) });
        Console.WriteLine($"Hello, {name}!");
    }

    private static void RunConfirmSample()
    {
        var answer = Prompt.Confirm("Are you ready?");
        Console.WriteLine($"Your answer is {answer}");
    }

    private static void RunPasswordSample()
    {
        var secret = Prompt.Password("Type new password", placeholder: "At least 8 characters", validators: new[] { Validators.Required(), Validators.MinLength(8) });
        Console.WriteLine($"Password OK, {secret}");
    }

    private static void RunSelectSample()
    {
        var city = Prompt.Select("Select your city", new[] { "Seattle", "London", "Tokyo", "New York", "Singapore", "Shanghai" }, pageSize: 3);
        Console.WriteLine($"Hello, {city}!");
    }

    private static void RunMultiSelectSample()
    {
        var options = Prompt.MultiSelect("Which cities would you like to visit?", new[] { "Seattle", "London", "Tokyo", "New York", "Singapore", "Shanghai" }, pageSize: 3, defaultValues: new[] { "Tokyo" });
        Console.WriteLine($"You picked {string.Join(", ", options)}");
    }


    private static void RunListSample()
    {
        var value = Prompt.List<string>("Please add item(s)");
        Console.WriteLine($"You picked {string.Join(", ", value)}");
    }

}
