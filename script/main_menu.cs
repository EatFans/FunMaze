using Godot;
using System;

public partial class main_menu : Control
{
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// 播放背景音乐
		BackgroundMusicManager.Instance.Play();
		GameManager.Instance.setInLevel(false);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}


	public void _on_start_game_button_pressed()
	{
		// GetTree().ChangeSceneToFile("res://scenes/levels/level1.tscn");
		GameManager.Instance.goLevel();
		GD.Print("进入关卡："+ GameManager.Instance.getCurrentLevel());
	}


	public void _on_exit_game_buttin_pressed()
	{
		GD.Print("正在退出游戏");
		BackgroundMusicManager.Instance.Stop(); 
		GetTree().Quit();
		// Replace with function body.
	}
}



