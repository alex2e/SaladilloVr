///////////////////////////////////////////
/// Práctica: SaladilloVr
/// Alumno/a: Alejandro Santillana
/// Curso: 2017/2018
/// Fichero: ButtonGazeClick.cs
///////////////////////////////////////////

using UnityEngine;
using UnityEngine.UI;

public class ButtonGazeClick : MonoBehaviour {
	/// <summary>
	/// Indica el tiempo de activación.
	/// </summary>
	public float activationTime = 3f;
	/// <summary>
	/// Indica si está mirandose.
	/// </summary>
	private bool isHover = false;
	/// <summary>
	/// Indica si la acción se ha realizado.
	/// </summary>
	private bool executed = false;

	// Use this for initialization
	void Start () {
		
	}
	
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
			GetComponent<Button>().onClick.Invoke();	
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
