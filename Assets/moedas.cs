using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class moedas : MonoBehaviour
{
	public GameObject TextoMoedas;
	public static int pontos;

	void Update()
	{
		pontos += 0;
		TextoMoedas.GetComponent<Text>().text = "Moedas:" +pontos;
	}
}
