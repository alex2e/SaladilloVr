///////////////////////////////////////////
/// Práctica: SaladilloVr
/// Alumno/a: Alejandro Santillana
/// Curso: 2017/2018
/// Fichero: SetButtonText.cs
///////////////////////////////////////////

using UnityEngine;
using UnityEngine.UI;

public class SetButtonText : MonoBehaviour
{

	public string text;
	public Text ipAdress;

	// Use this for initialization
	void Start ()
	{
		GetComponentInChildren<Text>().text = text;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Click()
	{
		ipAdress.text += text;
	}
}
