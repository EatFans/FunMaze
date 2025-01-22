using Godot;
using System;

public partial class level1 : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// GD.Print("当前关卡：" + GameManager.Instance.getCurrentLevel());
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	/**
	 *	当玩家点击Back按钮返回菜单
	 */
	public void _on_return_button_pressed()
	{

		GetTree().ChangeSceneToFile("res://scenes/ui/main_menu.tscn");
	}
}
