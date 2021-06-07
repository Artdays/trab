using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
	public CharacterController controle;

	public float speed = 12f;
	public float gravidade = -9.81f;
	public float alturapulo = 3f;

	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;

	Vector3 velocidade;
	bool isGrounded;

	void Update()
	{
		isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

		if (isGrounded && velocidade.y < 0)
		{
			velocidade.y = -2f;
		}

		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Vector3 move = transform.right * x + transform.forward * z;

		controle.Move(move * speed * Time.deltaTime);

		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			velocidade.y = Mathf.Sqrt(alturapulo * -2f * gravidade);
		}

		velocidade.y += gravidade * Time.deltaTime;

		controle.Move(velocidade * Time.deltaTime);
	}
}

