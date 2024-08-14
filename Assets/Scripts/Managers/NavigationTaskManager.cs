using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationTaskManager : SingletonBehaviour<NavigationTaskManager>
{
	[SerializeField]
	private List<GameObject> _spheres = new List<GameObject>(10);

	[SerializeField]
	private GameObject _exitDoor;

	private int currSpehere = 0;

	private void Awake()
	{
		SingletonInit(this);
	}

	public void PlaceNextSphere()
	{
		_spheres[currSpehere].SetActive(false);
		currSpehere++;

		if (currSpehere == _spheres.Count)
		{
			_exitDoor.SetActive(true);
		}
		else
		{
			_spheres[currSpehere].SetActive(true);
		}
	}
}
