using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOL : MonoBehaviour
{
	private void OnEnable()
	{
		DontDestroyOnLoad(this);
	}
}
