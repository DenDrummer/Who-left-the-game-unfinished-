using Godot;
using Godot.Collections;

public partial class UnfinishedGame : Node
{
    [Export]
    Camera2D Camera;
    [Export]
    Array Currencies;

    public override void _Ready()
    {
        GD.Print("Game Loaded");
    }
}
