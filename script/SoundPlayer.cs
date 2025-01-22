using Godot;
using System;

public partial class SoundPlayer : Node2D
{

	public static SoundPlayer Instance;

	private AudioStreamPlayer2D touchBlackTileSound;

	private AudioStreamPlayer2D nextLevelSound;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Instance = this;

		touchBlackTileSound = GetNode<AudioStreamPlayer2D>("TouchBlackTileSound");
		nextLevelSound = GetNode<AudioStreamPlayer2D>("NextLevelSound");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}


	public void playTouchBlackTileSound()
	{
		touchBlackTileSound.Play();
	}


	public void playNextLevelSound()
	{
		nextLevelSound.Play();
	}
}
