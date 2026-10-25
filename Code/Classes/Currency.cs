using Godot;
using System;

partial class Currency : Resource
{
    [Export]
    string name;
    ulong amount = 0;

    public Currency(string name)
    {
        this.name = name;
    }
}
