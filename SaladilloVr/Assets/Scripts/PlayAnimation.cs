﻿///////////////////////////////
// Alejandro Santillana Ruiz
// Curso 2017-2018
// PlayAnimation.cs
///////////////////////////////

using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
	/// <summary>
	/// Tiempo que tardará en activarse el puntero.
	/// </summary>
	public float activationTime = 3f;
	/// <summary>
	/// Indica si el puntero está sobre el objeto.
	/// </summary>
	private bool isHover = false;
	/// <summary>
	/// Indica si la acción se ha realizado.
	/// </summary>
	private bool executed = false;
	/// <summary>
	/// Objeto que contiene la animación.
	/// </summary>
	public GameObject player;

	// Update is called once per frame
	void Update () {
		//Si el usuario está mirando el objeto y el temporizador ha terminado de contar o si el usuario está mirando el objeto y pulsa el botón final del mando y la acción aun no se ha ejecutado, realizremos la acción correspondiente
		if ((isHover && CustomPointerTimer.CPT.ended && !executed) || (isHover && Input.GetButton("Fire1") && !executed))
		{
			//Indicamos que ya se ha ejecutado la acción...
			executed = true;
			//Desactivamos el contador de tiempo del cursor...
			CustomPointerTimer.CPT.StopCounting();
			//Se lanza la animación...
			player.GetComponent<Animator>().Play("ScrollDown");
		}
	}
	
	/// <summary>
	/// Método que llamaremos desde EventTrigger PointerEnter.
	/// </summary>
	public void StartHover()
	{
		isHover = true;
		executed = false;
		//Iniciamos el contador del puntero indicando el tiempo de activación
		CustomPointerTimer.CPT.StartCounting(activationTime);
	}
	
	/// <summary>
	/// Método que llamaremos desde EventTrigger PointerExit.
	/// </summary>
	public void EndHover()
	{
		isHover = false;
		//Iniciamos el contador del puntero indicando el tiempo de activación
		CustomPointerTimer.CPT.StopCounting();
	}
}
