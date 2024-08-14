using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SupermarketTaskManager : SingletonBehaviour<SupermarketTaskManager>
{
	[NonSerialized] public float SecondsStart;
	[NonSerialized] public float SecondsEnd;

	[SerializeField] private GameObject _uiCanvas;
	[SerializeField] private TextMeshPro _timeTxt;

	private bool taskHasEnded = false;

	private void Awake()
	{
		SingletonInit(this);
	}

	private void Start()
	{
		SecondsStart = Time.realtimeSinceStartup;
	}

	public void EndTask()
	{
		if (!taskHasEnded)
		{
			SecondsEnd = Time.realtimeSinceStartup;

			_uiCanvas.SetActive(true);
			_timeTxt.text = $"{Mathf.RoundToInt(SecondsEnd - SecondsStart)} segundos";

			taskHasEnded = true;
		}
	}
}
