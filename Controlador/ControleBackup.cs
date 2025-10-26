using System.IO;
using Batchup.Config;

namespace Batchup.Controlador
{
    public class ControleBackup
    {
        public void CriarArquivoBat (ConfigConexao conexao, ConfigBackup config, string destino)
        {
            string conteudo = $@"
@ECHO OFF
SETLOCAL ENABLEDELAYEDEXPANSION

:: ========= CONFIGURACOES =========
:: =========== CONEXAO ===========
set ""SERVIDOR={conexao.Servidor}""
set ""USUARIO={conexao.Usuario}""
set ""BANCO={conexao.Banco}""
set ""SENHA={conexao.Senha}""

:: =========== NOME-ARQUIVO ===========
set ""EMPRESA={config.Empresa}""
set ""CAIXA={config.Caixa}""

:: =========== LOCAIS ===============
set ""BACKUP={config.LocalBackup}""
set ""COPIA={config.LocalCopia}""
set ""DIAS={config.Dias}""

:: ========= PARAMETROS ============
for /f ""tokens=1-3 delims=/"" %%a in (""%date%"") do (
 set ""DIA=%%a""
 set ""MES=%%b""
 set ""ANO=%%c""
)
for /f ""tokens=1-2 delims=: "" %%a in (""%time%"") do (
 set ""HORA=%%a""
 set ""MINUTO=%%b""
)
set ""MYDATE=%ANO%-%MES%-%DIA%""
set ""MYTIME=%HORA%h%MINUTO%m""
set ""FILE=%EMPRESA%-CX%CAIXA%_%MYDATE%-%MYTIME%""

if not exist ""%BACKUP%"" mkdir ""%BACKUP%""

if ""%SENHA%""=="""" (
 mysqldump -u %USUARIO% -h %SERVIDOR% %BANCO% --ssl-mode=disabled --routines --triggers --events -P{conexao.Porta} > ""%BACKUP%%FILE%.sql""
) else (
 mysqldump -u %USUARIO% -p%SENHA% -h %SERVIDOR% %BANCO% --ssl-mode=disabled --routines --triggers --events -P{conexao.Porta} > ""%BACKUP%%FILE%.sql""
)

7z a ""%BACKUP%%FILE%.zip"" ""%BACKUP%%FILE%.sql"" -sdel

forfiles -p ""%BACKUP%"" -m *.zip -d -%DIAS% -c ""cmd /c del @path""
if exist ""%COPIA%"" (
 forfiles -p ""%COPIA%"" -m *.zip -d -%DIAS% -c ""cmd /c del @path""
)
if not exist ""%COPIA%"" mkdir ""%COPIA%""
copy ""%BACKUP%%FILE%.zip"" ""%COPIA%"" /y
ENDLOCAL
exit
";

            File.WriteAllText(destino, conteudo);
        }
    }
}
