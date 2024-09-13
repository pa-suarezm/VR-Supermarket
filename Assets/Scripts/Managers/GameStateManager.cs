using System.Collections;
using System.Collections.Generic;
using Unity.XR.OpenVR;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : SingletonBehaviour<GameStateManager>
{
	public Transform PlayerTransform;

	public string CurrentScene { get; set; }
	public string NextScene { get; set; }

	private void Awake()
	{
		SingletonInit(this);

		CurrentScene = Task.TASK_00;
		NextScene = Task.TASK_01;
	}

	public void GoToNextScene()
	{
		SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
		CurrentScene = NextScene;

		if (CurrentScene == Task.TASK_01)
		{
			NextScene = Task.TASK_02;
		}
		else if (CurrentScene == Task.TASK_02)
		{
			NextScene = Task.TASK_CHOOSE_MARKET;
		}
	}
}

public class Task
{
	public static string TASK_00 = "00-ReconocimientoInicial";
	public static string TASK_01 = "01-EjercicioLocalizacion";
	public static string TASK_02 = "02-EjercicioNavegacion";
	public static string TASK_SUFFIX_SUPERMARKET = "-EjercicioSupermercado";
	public static string TASK_CHOOSE_MARKET = "02B-EscogerSupermercado";
	public static string TASK_03 = $"03{TASK_SUFFIX_SUPERMARKET}1";
	public static string TASK_04 = $"04{TASK_SUFFIX_SUPERMARKET}2";
	public static string TASK_05 = $"05{TASK_SUFFIX_SUPERMARKET}3";
	public static string TASK_06 = $"06{TASK_SUFFIX_SUPERMARKET}4";
	public static string TASK_07 = $"07{TASK_SUFFIX_SUPERMARKET}5";
	public static string TASK_08 = $"08{TASK_SUFFIX_SUPERMARKET}6";
	public static string TASK_09 = $"09{TASK_SUFFIX_SUPERMARKET}7";
	public static string TASK_10 = $"10{TASK_SUFFIX_SUPERMARKET}8";
	public static string TASK_11 = $"11{TASK_SUFFIX_SUPERMARKET}9";
}
