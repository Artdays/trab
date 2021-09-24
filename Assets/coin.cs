using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{

    

    
    void Update()
    {
		transform.Rotate (1, 0, 0);
    }

	void OnTriggerEnter(Collider other)
	{
		moedas.pontos += 1;
		Destroy(gameObject);
	}
}
