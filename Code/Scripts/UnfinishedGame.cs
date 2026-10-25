using Godot;
using Godot.Collections;

public partial class UnfinishedGame : Node
{
    [Export]
    Array<Currency> Currencies = 
        [
            new("copper"),
            new("silver"),
            new("gold"),
            new("platinum"),
            new("mythril")
        ];

    public override void _Ready()
    {
    }
}
