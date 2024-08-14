using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorChooseSupermarket : MonoBehaviour
{
	[SerializeField] private SupermarketType marketType;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			ChooseNextScene();
		}
	}

	private void ChooseNextScene()
	{
		string sceneName = "";

		switch(marketType)
		{
			case SupermarketType.MARKET_1:
				sceneName = Task.TASK_03;
				break;

			case SupermarketType.MARKET_2:
				sceneName = Task.TASK_04;
				break;

			case SupermarketType.MARKET_3:
				sceneName = Task.TASK_05;
				break;

			case SupermarketType.MARKET_4:
				sceneName = Task.TASK_06;
				break;
		}

		GameStateManager.Instance.CurrentScene = sceneName;
		GameStateManager.Instance.NextScene = "";

		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}
}

public enum SupermarketType
{
	MARKET_1,
	MARKET_2,
	MARKET_3,
	MARKET_4
}
