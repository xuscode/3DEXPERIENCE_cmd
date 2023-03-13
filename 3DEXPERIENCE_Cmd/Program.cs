
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
            var type = Prompt.Select<CmdList>("Choose prompt list,选择命令");

            switch (type)
            {
                case CmdList.Animation_根据曲线生成截图:
                    GeneratateAnimation.GeneratateAnimation.CATMain();
                    break;
                case CmdList.SearchProductByType_通过名称和类型搜索文件:
                    PLMGetProduct.GetProduct.Run();
                      
                    break;
                case CmdList.SearchProductByName_通过自定义名称和类型搜索文件:
                    PLMGetProduct.GetProduct.RunCustomType();
                    break;
                case CmdList.Cmd_通过dos窗口调用CATIA的命令_英文版界面:
                    V6AllCmd.Program.Run();
                    break ;

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
