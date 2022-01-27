namespace mercatus_cli.builders
{
    public class MercatusMobile : Comandos
    {
        public override string GetHelp()
        {

            return $"{"mm".PadRight(10)} - Executa o publish do mercatus mobile, gera no desktop";
        }

        public override void Run(string[] opt)
        {
            var caminhoApp = "/home/andre/mercatus/atual/Sistemas/VisualStudio/MercatusMobile";
            var pastaDestino = "MercatusMobile";
            var caminhoDestino = $"/home/andre/Desktop/{pastaDestino}";

            string command = @$"
            cd {caminhoDestino}/../;
            rm -rf {pastaDestino};
            rm -r {pastaDestino}.tar.gz;

            cd {caminhoApp};

            dotnet clean;

            dotnet restore;

            dotnet build;

            cd {caminhoApp}/MercatusMobile;

            dotnet publish -r win-x64 -o {caminhoDestino};

            cd {caminhoDestino};

            rm -f *pdb;

            cd {caminhoDestino}/../;

            tar czf {pastaDestino}.tar.gz {pastaDestino};

            rm -rf {pastaDestino};
        ";

            CommandHelpers.ExecuteCommand(command);
        }
    }
}