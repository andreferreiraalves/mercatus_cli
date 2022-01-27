// See https://aka.ms/new-console-template for more information

using mercatus_cli.builders;

var flutter = new Flutter();
var mm = new MercatusMobile();

switch (args[0].ToUpper())
{
    case "--HELP":
        Console.WriteLine($"{flutter.GetHelp()} \n\r{mm.GetHelp()} \n\r ");
        break;

    case "FLUTTER":
        flutter.Run(args);
        break;

    case "MM":
        mm.Run(args);
        break;
}

