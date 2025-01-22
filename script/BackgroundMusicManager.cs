using Godot;
using System;

public partial class BackgroundMusicManager : Control
{
	public static BackgroundMusicManager Instance;

	private AudioStreamPlayer2D backgroundMusic;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Instance = this;

		// 获取节点
		backgroundMusic = GetNode<AudioStreamPlayer2D>("AudioStreamPlayer2D");

		if (backgroundMusic.Stream == null)
		{
			GD.Print("未找到该音频资源");
			return;
		}
		
		//backgroundMusic.Play();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	// 播放背景音乐
	public void Play()
	{
		if (!backgroundMusic.Playing)
		{
			backgroundMusic.Play();
		}
	}

	// 停止背景音乐
	public void Stop()
	{
		if (backgroundMusic.Playing)
		{
			backgroundMusic.Stop();
		}
	}

	
}
