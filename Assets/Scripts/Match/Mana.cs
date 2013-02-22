using UnityEngine;
using System.Collections;

public class Mana : MonoBehaviour 
{
	public GameObject Gui;
	public int _energy;
	
	void OnMouseDown()
	{
		/*Gui.GetComponent<GUI>().addSun(_energy);*/
		Destroy(this.gameObject);
	}
}
