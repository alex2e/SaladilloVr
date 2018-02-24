///////////////////////////////////////////
/// Práctica: SaladilloVr
/// Alumno/a: Alejandro Santillana
/// Curso: 2017/2018
/// Fichero: MovementDisc.cs
///////////////////////////////////////////

using UnityEngine;


public class MovementDisc : MonoBehaviour
{
	/// <summary>
	/// Máxima velocidad de desplazamiento.
	/// </summary>
	public float maxSpeed = 0.5f;
	
	/// <summary>
	/// Fuerza de empuje.
	/// </summary>
	public float pushForce = 10f;
	
	/// <summary>
	/// Nos indica si esta siendo mirada.
	/// </summary>
	[HideInInspector]
	public bool isHover;
	
	/// <summary>
	/// Referencia al Rigibody que queremos mover.
	/// </summary>
	public Rigidbody rigibody;
	
	// Use this for initializations
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isHover)
		{
			if (rigibody.velocity.magnitude < maxSpeed)
			{
				rigibody.AddForce((GvrPointerInputModule.Pointer.CurrentRaycastResult.worldPosition - transform.position).normalized * pushForce);
			}
		}
		
	}
	/// <summary>
	/// Acciones a realizar para el eventeo de mirara el disco.
	/// </summary>
	public void StartLookingAtDisc()
	{
		isHover = true;
	}
	/// <summary>
	/// Acciones a realizar para el evento de dejar de mirar el disco.
	/// </summary>
	public void StopLookingAtDisc()
	{
		isHover = false;
	}
}
