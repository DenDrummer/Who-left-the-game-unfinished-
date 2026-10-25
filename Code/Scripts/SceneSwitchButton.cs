using Godot;

public partial class SceneSwitchButton : Button
{
    [Export]
    PackedScene NextScene;

    public void Continue()
    {
        SceneTree tree = GetTree();
        //tree.UnloadCurrentScene();
        tree.ChangeSceneToPacked(NextScene);
    }
}
