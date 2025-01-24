using Godot;
using System;

/**
 * 	一号怪物类，一号怪物只会在指定位置等待玩家接近，玩家接近怪物，怪物开始追击玩家，碰到玩家就重置场景
 */
public partial class monster1 : CharacterBody2D
{
	private Node2D player;  // 玩家节点
	public const float Speed = 300.0f;
	public float detectionRadius = 200.0f;  // 追击范围
	public const float JumpVelocity = -400.0f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

    public override void _Ready()
    {

		var levelNode = GetTree().CurrentScene;
		player = levelNode.GetNode<CharacterBody2D>("Player");
		
		if (player != null)
			GD.Print("已经获取玩家节点："+player.Name);

    }


    // TODO: 一号怪物开始时候是保持不动的，当玩家接近一号怪物指定距离的时候，一号怪物开始移动追击玩家，直到碰到玩家，重置当前场景
    public override void _PhysicsProcess(double delta)
	{
		if (player == null)
			return;
		float distanceToPlaye = Position.DistanceTo(player.Position); // 获取与玩家的距离

		// 检查与玩家的距离
		if (distanceToPlaye <= detectionRadius)
		{
			// 如果在追击的范围，开始追击玩家
		}
	}
}
