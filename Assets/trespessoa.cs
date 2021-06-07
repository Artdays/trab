using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trespessoa : MonoBehaviour
{
   
    void Update()
    {
		if (Input.GetKey(KeyCode.L))
		{
			transform.localPosition = new Vector3(0f, 1.5f, -2.8f);
		}

		if (Input.GetKey(KeyCode.K))
		{
			transform.localPosition = new Vector3(0f, 0.8f, 0f);
		}
	}
}
