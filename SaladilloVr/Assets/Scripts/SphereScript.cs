///////////////////////////////////////////
/// Práctica: SaladilloVr
/// Alumno/a: Alejandro Santillana
/// Curso: 2017/2018
/// Fichero: SphereScript.cs
///////////////////////////////////////////

using UnityEngine;

public class SphereScript : MonoBehaviour
{
	/// <summary>
	/// Material de la esfera cuando no está siendo mirada
	/// </summary>
	public Material sphereMaterial;
	/// <summary>
	/// Material de la esfera cuando está siendo mirada
	/// </summary>
	public Material sphereHoverMaterial;
	
	/// <summary>
	/// Cuando se inicia el Script.
	/// </summary>
	/// <remarks>
	/// Se le da a la Sphere el material de inicio.
	/// </remarks>
	void Start ()
	{
		GetComponent<Renderer>().material = sphereMaterial;	
	}
	/// <summary>
	/// Cuando se empieza a mirar la esfera.
	/// </summary>
	/// <remarks>
	/// Cambio el material de la esfera.
	/// </remarks>
	public void HoveredSphere()
	{
		GetComponent<Renderer>().material = sphereHoverMaterial;
	}
	
	/// <summary>
	/// Cuando se deja de mirar la esfera.
	/// </summary>
	/// <remarks>
	/// Cambio el material de la esfera de nuevo.
	/// </remarks>
	public void NotHoveredSphere()
	{
		GetComponent<Renderer>().material = sphereMaterial;
	}
}
