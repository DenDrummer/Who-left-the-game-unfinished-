using Godot;

public partial class PlayerResource : Resource
{
    [Export]
    public string Name;
    public ulong Amount = 0;

    public PlayerResource(string name)
    {
        Name = name;
    }

    public PlayerResource(string name, ulong amount)
    {
        Name = name;
        Amount = amount;
    }
}
