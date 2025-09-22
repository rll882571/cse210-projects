using System; /* OQUE É ESSA LINHA? A LINHA 'USING SYSTEM' É UMA DIRETIVA DE NOME
 DE ESPAÇO (NAMESPACE) EM C#. ELA PERMITE QUE O PROGRAMA ACESSE AS CLASSES E MÉTODOS
DEFINIDOS NO NOME DE ESPAÇO 'SYSTEM', QUE É UMA PARTE FUNDAMENTAL DA BIBLIOTECA PADRÃO DO 
.NET. ESSA LINHA É NECESSÁRIA PARA USAR FUNCIONALIDADES BÁSICAS COMO ENTRADA E SAÍDA (CONSOLE), 
MANIPULAÇÃO DE DATAS, ENTRE OUTRAS. SEM ESSA LINHA ..*/

public class Entry /* AQUI EU ESTOU CRIANDO UMA CLASSE CHAMADA ENTRY. UMA CLASSE É UM MOLDE PARA 
CRIAR OBJETOS. OBJETOS SÃO INSTÂNCIAS DE UMA CLASSE, OU SEJA, SÃO CRIADOS A PARTIR DO MOLDE 
DEFINIDO PELA CLASSE. ESSA CLASSE ENTRY VAI SER USADA PARA REPRESENTAR UMA ENTRADA NO DIÁRIO. 
CADA ENTRADA  VAI TER UM TEXTO, UMA DATA E UM TEMA.*/
{
    public string _date;
    public string _promptText;
    public string _entryText;
     public List<string> _tags = new List<string>(); // new line to hold tags

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        if (_tags.Count > 0)
        {
            Console.WriteLine($"Tags: {string.Join(", ", _tags)}");
        }
    }
}
