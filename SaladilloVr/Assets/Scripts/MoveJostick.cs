using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJostick : MonoBehaviour {
	
	/// <summary>
	/// Máxima velocidad de desplazamiento.
	/// </summary>
	public float maxSpeed = 0.5f;
	
	/// <summary>
	/// Fuerza de empuje.
	/// </summary>
	public float pushForce = 10f;
	
	/// <summary>
	/// Referencia al Rigibody que queremos mover.
	/// </summary>
	public Rigidbody rigibody;

	
	void Awake()
	{
		rigibody = GetComponent<Rigidbody>();
	}
	
	
	void FixedUpdate ()
	{
		//Recuperamos el valor de los ejes horizontal y vertical, son valores normalizados que van de cero a uno.
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis(("Vertical"));
		
		//Calculamos el vector de movimiento con la dirección con la que mira la cámara
		Vector3 moveDirection = (h * Camera.main.transform.right + v * Camera.main.transform.forward).normalized;

		if (rigibody.velocity.magnitude < maxSpeed)
		{
			rigibody.AddForce(moveDirection * pushForce);
		}
	}
}
