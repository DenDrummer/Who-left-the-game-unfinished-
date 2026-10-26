using Godot;
using Godot.Collections;
using System.Collections.Generic;

public partial class UnfinishedGame : Node
{
    [Export]
    List<PlayerResource> PlayerResources = [];
    [Export]
    List<string> Unlocks = [];

    void AddResource(PlayerResource playerResource)
    {
        PlayerResource resource = PlayerResources.Find(pr => pr.Name == playerResource.Name);
        if (resource == null)
        {
            PlayerResources.Add(playerResource);
            return;
        }
        resource.Amount += playerResource.Amount;
    }

    void AddResource(string name, ulong amount)
    {
        PlayerResource resource = PlayerResources.Find(pr => pr.Name == name);
        if (resource == null)
        {
            PlayerResources.Add(new(name, amount));
            return;
        }
        resource.Amount += amount;
    }
}
