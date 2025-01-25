using Godot;
using System;

/**
 * 	一号怪物类，一号怪物只会在指定位置等待玩家接近，玩家接近怪物，怪物开始追击玩家，碰到玩家就重置场景
 */
public partial class monster1 : CharacterBody2D
{
	private Node2D player;  // 玩家节点
	public const float Speed = 100.0f;
	public float detectionRadius = 120.0f;  // 追击范围
	public const float JumpVelocity = -400.0f;

	private bool isPursue = false;  // 是否进入追击状态开关


	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

    public override void _Ready()
    {

		var levelNode = GetTree().CurrentScene;
		player = levelNode.GetNode<CharacterBody2D>("Player");
		
		if (player == null)
			GD.Print("未获取玩家节点");

		GD.Print("一号怪物已经加载");

    }


    public override void _PhysicsProcess(double delta)
	{
		if (player == null)
			return;
		float distanceToPlaye = Position.DistanceTo(player.Position); // 获取与玩家的距离

		// 检查与玩家的距离
		if (distanceToPlaye <= detectionRadius)
		{
			// 如果在追击的范围，开始追击玩家
			isPursue = true;
			// GD.Print("一号怪物开始追击玩家");
		}
		if (isPursue)
		{
			// 开始追击玩家
			PursuePlayer(delta);
		}

		CheckCollisionWithPlayer();

	}

	private void PursuePlayer(double delta)
    {
        // 计算怪物追向玩家的方向（单位向量）
        Vector2 directionToPlayer = (player.Position - Position).Normalized();

        // 设置速度向量
        Velocity = directionToPlayer * Speed;

        // 调用 MoveAndSlide 来更新怪物的位置
        MoveAndSlide();
		// GD.Print("追击中...");
    }

	private void CheckCollisionWithPlayer()
	{
		// GD.Print("玩家距离怪物的距离"+Position.DistanceTo(player.Position));
		if (Position.DistanceTo(player.Position) < 21.0f)
		{
			GD.Print("一号怪物已经触碰到玩家");
			SoundPlayer.Instance.playTouchBlackTileSound();
			GetTree().ReloadCurrentScene();
		}
	}
}
