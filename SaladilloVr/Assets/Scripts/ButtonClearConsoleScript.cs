///////////////////////////////////////////
/// Práctica: SaladilloVr
/// Alumno/a: Alejandro Santillana
/// Curso: 2017/2018
/// Fichero: ButtonClearConsoleScript.cs
///////////////////////////////////////////
using UnityEngine;
using UnityEngine.UI;

public class ButtonClearConsoleScript : MonoBehaviour {
	
	public string text;
	public Text ipAdress;

	private void Start()
	{
		GetComponentInChildren<Text>().text = text;
	}

	public void Click()
	{
		ipAdress.text = "";
	}
}
