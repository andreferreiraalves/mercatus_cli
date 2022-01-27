using System.Diagnostics;

public class Flutter : Comandos
{
    public override string GetHelp()
    {
        return $"{"flutter".PadRight(10)} - Executa o build do branch em questão";
    }

    public override void Run(string[] opt)
    {
        string command = @$"
            cd /home/andre/mercatus/atual/Sistemas/VisualStudio/MercatusMobileClients/forca_vendas/;

            flutter clean;

            flutter pub get;

            flutter build apk;
        ";

        CommandHelpers.ExecuteCommand(command);
    }
}