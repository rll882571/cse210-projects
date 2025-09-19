using System.IO;

public class Jornal
{
    public List<Entry> _anotacoes = new List<Entry>();

    public void AddEntry(Entry novaAnotacao)
    {
        _anotacoes.Add(novaAnotacao);
    }

    public void Display()
    {
        Console.WriteLine("--- Anotações do Diário ---");
        foreach (Entry anotacao in _anotacoes)
        {
            anotacao.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry anotacao in _anotacoes)
            {
                outputFile.WriteLine($"{anotacao._date}|{anotacao._promptText}|{anotacao._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _anotacoes.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Entry novaAnotacao = new Entry();
            novaAnotacao._date = parts[0];
            novaAnotacao._promptText = parts[1];
            novaAnotacao._entryText = parts[2];

            _anotacoes.Add(novaAnotacao);
        }
    }
}