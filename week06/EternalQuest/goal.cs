public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Este método é abstrato, forçando as classes filhas a implementarem
    // como um evento é registrado e quantos pontos ele vale.
    public abstract int RecordEvent();

    // Este método é abstrato, forçando as classes filhas a definirem
    // sua própria lógica para saber se estão completas.
    public abstract bool IsComplete();

    // Este método é virtual, fornecendo uma implementação padrão que pode
    // ser usada ou sobrescrita pelas classes filhas.
    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }

    // Este método é abstrato, forçando as classes filhas a fornecerem
    // uma string formatada para salvar em arquivo.
    public abstract string GetStringRepresentation();
}