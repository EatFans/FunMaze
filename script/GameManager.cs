using Godot;
using System;


/**
 *  GameManager类用于管理游戏状态，继承Node2D节点类
 */
public partial class GameManager : Node2D
{
	public static GameManager Instance;

	private int currentLevel; // 当前的关卡

	private bool inLevel; // 是否在关卡中

	/**
	 *  GameManager节点在游戏引擎创建时候，运行该方法
	 */
	public override void _Ready()
	{
		Instance = this;
		// 初始化
		inLevel = false;
		currentLevel = 0;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	/**
	 *  获取是否在关卡中
	 *  @return 返回是否在关卡中 bool类型
	 */
	public bool isInLevel()
	{
		return inLevel;
	}

	/**
	 *	设置是否在关卡中
	 *  @param flag bool类型值true为是，false为不是
	 */
	public void setInLevel(bool flag)
	{
		inLevel = flag;
	}

	/**
	 *	获取当前所在关卡
	 *  @return 返回关卡标号，如果是0，就表示在菜单中
	 */
	public int getCurrentLevel()
	{
		return currentLevel;
	}

	/**
	 *	设置当前所在关卡
	 *  @param levelIndex 关卡编号索引，如果是0就表示在菜单中
	 */
	public void setCurrentLevel(int levelIndex)
	{
		currentLevel = levelIndex;
	}

	/**
	 *  进入下一关
	 */
	public void goNextLevel()
	{
		currentLevel++;
		inLevel = true;
		GD.Print("进入关卡：" + currentLevel);
		switch (currentLevel)
		{
			case 1:
				GetTree().ChangeSceneToFile("res://scenes/levels/level1.tscn");
				break;
			case 2:
				GetTree().ChangeSceneToFile("res://scenes/levels/level2.tscn");
				break;
			case 3:
				GetTree().ChangeSceneToFile("res://scenes/levels/level3.tscn");
				break;
			case 4:
				GetTree().ChangeSceneToFile("res://scenes/levels/level4.tscn");
				break;
			case 5:
				GetTree().ChangeSceneToFile("res://scenes/levels/level5.tscn");
				break;
			default:
				break;
		}
	}

	/**
	 *	进入关卡
	 */
	public void goLevel()
	{
		inLevel = true;
		if (currentLevel == 0)
			currentLevel++;
		switch (currentLevel)
		{
			case 1:
				GetTree().ChangeSceneToFile("res://scenes/levels/level1.tscn");
				break;
			case 2:
				GetTree().ChangeSceneToFile("res://scenes/levels/level2.tscn");
				break;
			case 3:
				GetTree().ChangeSceneToFile("res://scenes/levels/level3.tscn");
				break;
			case 4:
				GetTree().ChangeSceneToFile("res://scenes/levels/level4.tscn");
				break;
			case 5:
				GetTree().ChangeSceneToFile("res://scenes/levels/level5.tscn");
				break;
			default:
				break;
		}
	}
}
