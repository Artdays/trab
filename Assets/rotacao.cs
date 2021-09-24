using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacao : MonoBehaviour
{
	int girar;
	Vector3 a;
	void Start()
	{
		girar = 0;
		classemae mae = new classemae();
		classemae.Girar = girar;
	}

	public void girosflin()
	{
		a.y = 2.0f;
		Rotacao(a);
		a.y = 0.0f;
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.X))
		{
			girar += 1;
		}
		else
		{
			girar = 0;
		}

		if (girar > 0)
		{
			girosflin();
		}
	}

	void Rotacao(Vector3 x)
	{
		transform.Rotate(x);
	}

}
