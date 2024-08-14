using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawnManager : MonoBehaviour
{
	private void Start()
	{
		GameStateManager.Instance.PlayerTransform.SetPositionAndRotation(transform.position, transform.rotation);
	}
}
