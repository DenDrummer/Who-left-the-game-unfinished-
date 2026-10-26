using Godot;
using Godot.Collections;
using System;

public partial class Upgrade : Node
{
    [Export]
    string name;
    [Export]
    Array<PlayerResource> costs = [];
    [Export]
    bool bought = false;

    public void TryBuy()
    {
        throw new NotImplementedException();
    }
}
