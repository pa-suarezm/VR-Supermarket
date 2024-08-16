using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using static UnityEngine.InputSystem.InputAction;

public class CustomInputManager : SingletonBehaviour<CustomInputManager>
{
  [SerializeField] private InputActionReference _rightHandPrimaryBtnPress;

  private void Awake()
  {
    SingletonInit(this);
  }

  private void Start()
  {
    _rightHandPrimaryBtnPress.action.performed += RightHandPrimaryBtnPress;
  }

  private void RightHandPrimaryBtnPress(CallbackContext context)
  {
    if (GameStateManager.Instance.CurrentScene == Task.TASK_00)
    {
      // Only the first Task should be skippable with the A button
      GameStateManager.Instance.GoToNextScene();
    }
    else if (GameStateManager.Instance.CurrentScene.Contains(Task.TASK_SUFFIX_SUPERMARKET))
    {
      if (SupermarketTaskManager.Instance != null)
        SupermarketTaskManager.Instance.EndTask();
    }
    /* // For debugging purposes
    else
		{
			GameStateManager.Instance.GoToNextScene();
		}*/
  }
}
