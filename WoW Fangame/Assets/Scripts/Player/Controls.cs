using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
	private Player playerScript;

	private void Awake()
	{
		playerScript = GetComponent<Player>();
	}

	public void Jump(InputAction.CallbackContext context)
	{
		if (context.performed)
			playerScript.Jump();
	}
}
