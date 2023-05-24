using System;
using UnityEngine.SceneManagement;

public static class LevelLoader
{
	public enum Scene
	{
		MenuScene,
		LoadingScene,
		GameScene
	}

	private static Action onLevelLoaderCallback;

	public static void load(Scene scene)
	{
		onLevelLoaderCallback = () =>
		{
			SceneManager.LoadScene(scene.ToString());
		};
		SceneManager.LoadScene(Scene.LoadingScene.ToString());
	}

	public static void LevelLoaderCallback()
	{
		if (onLevelLoaderCallback != null)
		{
			onLevelLoaderCallback();
			onLevelLoaderCallback = null;
		}
	}
}