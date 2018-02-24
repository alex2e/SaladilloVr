///////////////////////////////////////////
/// Práctica: SaladilloVr
/// Alumno/a: Alejandro Santillana
/// Curso: 2017/2018
/// Fichero: ButtonDeleteConsoleScript.cs
///////////////////////////////////////////
using UnityEngine;
using UnityEngine.UI;

public class ButtonDeleteConsoleScript : MonoBehaviour {
	
	public string text;
	public Text ipAdress;

	// Use this for initialization
	void Start () {
		GetComponentInChildren<Text>().text = text;
	}

	public void Click()
	{
		ipAdress.text = ipAdress.text.Substring(0, ipAdress.text.Length-1);
	}
}
