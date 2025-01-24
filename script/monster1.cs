using Godot;
using System;

/**
 * 	一号怪物类，一号怪物只会在指定位置等待玩家接近，玩家接近怪物，怪物开始追击玩家，碰到玩家就重置场景
 */
public partial class monster1 : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();



	// TODO: 当玩家接近一号怪物时候，一号怪物开始移动追击玩家，直到碰到玩家，重置当前场景
	public override void _PhysicsProcess(double delta)
	{
		
	}
}
