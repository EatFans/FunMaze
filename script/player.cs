using Godot;
using System;
using System.Net.Security;


public partial class player : CharacterBody2D
{
    public const float Speed = 100.0f;

	private bool isSwitchingLevel = false;
    public override void _Ready()
    {

    }

    public override void _PhysicsProcess(double delta)
    {
		if (isSwitchingLevel) 
			return;
        // 获取输入方向
        Vector2 direction = Input.GetVector("move_left", "move_right", "move_up", "move_down");

        // 更新玩家的位置
        Position += direction * Speed * (float)delta;
		

		// 检查玩家如果移动碰到了，TileMap中图块id为1点图块，就打印黑色
		// 如果碰到了TileMap中图块id为2图块，就打印蓝色
		// 获取 TileMap 节点（确保 TileMap 节点是玩家的父节点或调整路径）
        var tileMap = GetParent().GetNode<TileMap>("TileMap");
		Vector2I cell = tileMap.LocalToMap(GlobalPosition);
		int tileId = tileMap.GetCellSourceId(0, cell);

		if (tileId == 1)
		{
			// 如果碰到黑色就重载当前关卡
			SoundPlayer.Instance.playTouchBlackTileSound();
	        GD.Print($"初始化玩家位置 {Position}");
            GetTree().ReloadCurrentScene();

		} else if (tileId == 3)
		{
			// 播放过关音效
			SoundPlayer.Instance.playNextLevelSound();
			isSwitchingLevel = true; // 设置标志
			// 延迟0.5秒跳入下一关
			GameManager.Instance.goNextLevel();
		}

    }

	

}
