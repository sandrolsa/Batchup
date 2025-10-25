using System.IO;
using System.Text;

public class Bat
{
    public string GenBat(Conexao conexao, Config config)
    {
        // Dados do usuário
        string userInput = $@"@ECHO OFF
SETLOCAL ENABLEDELAYEDEXPANSION

::	========= CONFIGURACOES =========

:: =========== CONEXAO ===========

	set ""SERVIDOR={conexao.Servidor}""
	set ""USUARIO={conexao.Usuario}""
	set ""BANCO={conexao.Porta}""
	set ""SENHA={conexao.Senha}""

:: =========== NOME-ARQUIVO ===========

	set ""EMPRESA={backup.Empresa}""
	set ""CAIXA={backup.Caixa}""

:: =========== LOCAIS ===============

	set ""BACKUP={config.Diretorio}""
	set ""COPIA={config.Copia}""
	set ""DIAS={config.Dias}""

::	========= CONFIGURACOES =========



:: ========= PARAMETROS ============

:: Captura data no formato dd-mm-aa
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

:: ======== CHECA PASTA BACKUP ===========
if not exist ""%BACKUP%"" mkdir ""%BACKUP%""

:: ======== DUMP ===========
echo [INFO] Gerando backup do banco %BANCO%...
if ""%SENHA%""=="""" (
    mysqldump -u %USUARIO% -h %SERVIDOR% %BANCO% --ssl-mode=disabled --routines --triggers --events -P3306 > ""%BACKUP%%FILE%.sql""
) else (
    mysqldump -u %USUARIO% -p%SENHA% -h %SERVIDOR% %BANCO% --ssl-mode=disabled --routines --triggers --events -P3306 > ""%BACKUP%%FILE%.sql""
)

if errorlevel 1 (
    echo [ERRO] Falha ao gerar backup.
    exit /b
) else (
    echo [SUCESSO] Backup finalizado.
)

:: ======== ZIP ===========

echo [INFO] Compactando arquivo...
7z a ""%BACKUP%%FILE%.zip"" ""%BACKUP%%FILE%.sql"" -sdel

if exist ""%BACKUP%%FILE%.zip"" (
    echo [SUCESSO] Arquivo compactado: %FILE%.zip
) else (
    echo [ERRO] Falha ao compactar.
)

:: ======== DELETA ANTIGOS ===========

echo [INFO] Limpando arquivos antigos com mais de %DIAS% dias...
forfiles -p ""%BACKUP%"" -m *.zip -d -%DIAS% -c ""cmd /c del @path""
if exist ""%COPIA%"" (
    forfiles -p ""%COPIA%"" -m *.zip -d -%DIAS% -c ""cmd /c del @path""
)

:: ======== COPIA ARQUIVO ===========
echo [INFO] Copiando arquivo para %COPIA%...
if not defined COPIA (
    echo [ERRO] Diretorio de Copia nao definida.
    exit /b
)

if not exist ""%COPIA%"" mkdir ""%COPIA%""
copy ""%BACKUP%%FILE%.zip"" ""%COPIA%"" /y

if errorlevel 1 (
    echo [ERRO] Falha na cópia.
) else (
    echo [SUCESSO] Cópia concluída.
)

echo [FIM] Backup completo.
ENDLOCAL
exit /b
";
        return userInput;
    }

    public void SalvaBat(string caminho, string conteudo)
    {
        // Salva arquivo
        File.WriteAllText(caminho, conteudo, Encondig.GetEnconding(850));
    }
}