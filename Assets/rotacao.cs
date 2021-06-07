using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacao : MonoBehaviour
{
	Vector3 a;
    void Start()
    {
        
    }

	void Update()
	{
		if (Input.GetKey(KeyCode.X))
		{
			a.y = 2.0f;
			Rotacao(a);
			a.y = 0.0f;

		}
	}

	void Rotacao(Vector3 x)
	{
		transform.Rotate(x);
	}

}
