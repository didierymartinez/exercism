abstract class Character
{
    private string _characterType;
    
    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {_characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    bool isPrepareSpell = false;
    
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target) => isPrepareSpell ? 12 : 3;

    public void PrepareSpell() => isPrepareSpell = true;

    public override bool Vulnerable() => !isPrepareSpell;
}
