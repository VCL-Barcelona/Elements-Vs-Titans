using UnityEngine;
using System.Collections;

public class MySky : MonoBehaviour 
{
	public GameObject Mana;
    public GameObject gui;

	public void createMana()
	{
		int _randEnergy = Random.Range(0,51);
		int _randx = Random.Range(0,10);
		int _randz = Random.Range(0,5);
		
		Vector3 Pos = new Vector3(_randx,7,_randz);
		GameObject mana = (GameObject)Instantiate(Mana, Pos, Quaternion.identity);
		var _manaAux = mana.GetComponent<Mana>();
		_manaAux._energy = _randEnergy;
        _manaAux.Gui = gui;
		
	}
	// Use this for initialization
	void Start () {
		InvokeRepeating("createMana",7.0f,7.0f);
	}

}
