///////////////////////////////
// Alejandro Santillana Ruiz
// Curso 2017-2018
// CustomPointerTime.cs
///////////////////////////////
using UnityEngine;
using UnityEngine.UI;
public class CustomPointerTimer : MonoBehaviour
{
	/// <summary>
	///Objeto compartido por todos los Scripts.
	/// </summary>
	public static CustomPointerTimer CPT;
	/// <summary>
	/// Tiempo por defecto que vamos a tener que esperar para que el contador se rellene.
	/// </summary>
	private float timeToWait = 3f;
	/// <summary>
	/// Temporizador.
	/// </summary>
	private float timer = 0f;
	/// <summary>
	/// Componente Image de la imagen de relleno.
	/// </summary>
	private Image image;
	/// <summary>
	/// Cuando está contando.
	/// </summary>
	[HideInInspector] //Para que no salga en Unity aunque sea público
	public bool counting = false;
	/// <summary>
	/// Indica si ha llegado al final.
	/// </summary>
	[HideInInspector]
	public bool ended = false;
	
	/// <summary>
	/// Se invoca antes de que Start
	/// </summary>
	void Awake () {
		
		//Se comprueba si el objeto está inicializado
		if (CPT == null)
		{
			//Se obtiene el obejto temporizador
			CPT = GetComponent<CustomPointerTimer>();
		}
		//Se objetiene la imagen del reloj
		image = GetComponentInChildren<Image>();
	}
	
	void Update () {
		if (counting)
		{
			// Se incrementa el temporizador la porción del tiempo que ha tardado en renderizar el último update . De esta manera se tiene un control de tiempo real independientemente de las caracteristicas de la máquina
			timer += Time.deltaTime;
			//Se rellena la imagen la cantidad proporcional al temporizador
			image.fillAmount = timer / timeToWait;
		}
		else
		{
			// Se reinicia el temporizador y el relleno de la imagen
			timer = 0;
			image.fillAmount = timer;
		}
		
		//Se comprueba si se ha cumplido el tiempo de espera
		if (timer >= timeToWait)
		{
			//Se indica que el contador ha finalizado
			ended = true;
		}
	}
	
	/// <summary>
	/// Inicia el temporizador utilizando el tiempo indicado como parametro.
	/// </summary>
	/// <param name="time">Tiempo de espera.</param>
	public void StartCounting(float time)
	{
		counting = true;
		ended = false;
		timeToWait = time;
	}
	
	/// <summary>
	/// Para el temporizador.
	/// </summary>
	public void StopCounting()
	{
		counting = false;
		ended = true;
	}
}
