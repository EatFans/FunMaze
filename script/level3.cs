using Godot;
using System;

public partial class level3 : Node2D
{

	public override void _Ready()
	{
	}


	public override void _Process(double delta)
	{
	}

	public void _on_return_button_pressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/ui/main_menu.tscn")
	}
}
