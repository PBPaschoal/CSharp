using System;
using System.Diagnostics;
using System.Security.Principal;

namespace LimpadorPro {
    class Program {
        static void Main(string[] args) {
            // Verifica se o programa está rodando como Administrador
            if (!IsAdministrator()) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO: Este programa precisa ser executado como Administrador!");
                Console.ResetColor();
                Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
                return;
            }

            Console.Title = "Limpeza PRO Windows - C# Edition";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==========================================");
            Console.WriteLine("    INICIANDO LIMPEZA DE SISTEMA          ");
            Console.WriteLine("==========================================\n");
            Console.ResetColor();

            // Aqui está o "pulo do gato": o script PowerShell dentro de uma string
            // Usamos o caractere @ para permitir strings de múltiplas linhas
            string scriptPowerShell = @"
                $totalLiberado = 0
                $pastas = @('C:\Windows\Temp', $env:TEMP, 'C:\Windows\Prefetch', 'C:\Windows\SoftwareDistribution\Download')
                
                foreach ($pasta in $pastas) {
                    if (Test-Path $pasta) {
                        Write-Host ""Limpando: $pasta"" -ForegroundColor Cyan
                        
                        # Calcula tamanho antes de tentar apagar
                        $arquivos = Get-ChildItem $pasta -Recurse -Force -ErrorAction SilentlyContinue
                        $tamanhoAntes = ($arquivos | Measure-Object -Property Length -Sum).Sum
                        
                        # Tenta apagar TUDO (arquivos e subpastas)
                        # O -Recurse aqui dentro do Remove-Item é o segredo
                        Get-ChildItem $pasta -Recurse -Force | Remove-Item -Recurse -Force -ErrorAction SilentlyContinue
                        
                        # Calcula o que restou para saber quanto foi limpo de verdade
                        $arquivosDepois = Get-ChildItem $pasta -Recurse -Force -ErrorAction SilentlyContinue
                        $tamanhoDepois = ($arquivosDepois | Measure-Object -Property Length -Sum).Sum
                        
                        $totalLiberado += ($tamanhoAntes - $tamanhoDepois)
                    }
                }

                # Limpeza extra: Lixeira (agora mais profunda)
                Write-Host 'Limpando Lixeira...' -ForegroundColor Cyan
                Clear-RecycleBin -Force -ErrorAction SilentlyContinue
                
                $totalMB = [Math]::Round($totalLiberado / 1MB, 2)
                Write-Host '----------------------------------'
                Write-Host ""Espaço total recuperado: $totalMB MB"" -ForegroundColor Green
            ";

            ExecutarPowerShell(scriptPowerShell);

            Console.WriteLine("\nProcesso finalizado. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }

        // Método para verificar se é Admin
        static bool IsAdministrator() {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        // Método que invoca o PowerShell e passa o script
        static void ExecutarPowerShell(string script) {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "powershell.exe";
            // O argumento -Command executa a string que criamos
            psi.Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{script}\"";
            psi.UseShellExecute = false;

            Process process = new Process();
            process.StartInfo = psi;
            process.Start();
            process.WaitForExit();
        }
    }
}