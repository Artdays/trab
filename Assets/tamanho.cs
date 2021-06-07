using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamanho : MonoBehaviour
{

	void Update()
    {
		if (Input.GetKey(KeyCode.Mouse2))
		{
			transform.localScale = new Vector3 (0.3f, 0.3f, 0.3f);
		}

		if (Input.GetKey(KeyCode.Mouse4))
		{
			transform.localScale = new Vector3(1f, 1f, 1f);
		}

		if (Input.GetKey(KeyCode.Mouse3))
		{
			transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
		}
	}
}
