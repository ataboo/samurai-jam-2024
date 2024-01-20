using Godot;
using SamuraiEngine;

public class LevelControl : Node2D
{
    public LevelState levelState = LevelStateService.CreateLevel();



    public override void _Ready()
    {
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
