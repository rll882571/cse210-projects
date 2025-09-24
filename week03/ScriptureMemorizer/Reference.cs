public class Reference
{
    // 1. CAMPOS PRIVADOS (Os Espaços de Armazenamento do Endereço)
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // 2. CONSTRUTOR 1: Verso Único (Ex: "João 3:16")
    // Recebe apenas UM número de verso.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        // Se for um verso único, o verso final é igual ao inicial.
        _endVerse = verse;
    }

    // 3. CONSTRUTOR 2: Intervalo de Versos (Ex: "Provérbios 3:5-6")
    // Recebe o verso inicial e o verso final.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // 4. MÉTODO PARA EXIBIR (Monta a string do Endereço)
    public string GetDisplayText()
    {
        // Verifica se o verso inicial é diferente do verso final.
        if (_startVerse == _endVerse)
        {
            // Formato: Livro Capítulo:Verso (Ex: João 3:16)
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            // Formato: Livro Capítulo:VersoInicial-VersoFinal (Ex: Provérbios 3:5-6)
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}