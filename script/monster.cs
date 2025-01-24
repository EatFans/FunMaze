using Godot;
using System;

/**
 *  怪物节点类
 */
public partial class monster : CharacterBody2D
{
	public const float Speed = 80.0f; // 速度

    public override void _Ready()
    {
        GD.Print("怪物已经加载");
    }

    public override void _PhysicsProcess(double delta)
	{
		
	}
}
