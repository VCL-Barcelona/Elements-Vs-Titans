using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class Data : MonoBehaviour {

    public string deffensesPath;
    public List<GameObject> Deffenses;
    public List<GameObject> Offenses;
    public List<GameObject> Levels;
    public List<GameObject> Manas;

	void Start () 
    {
        Deffenses = new List<GameObject>();
        Offenses  = new List<GameObject>();
        Levels    = new List<GameObject>();
        Manas     = new List<GameObject>();
        Load();
	}

    public void Load()
    {        
        Object[] defenses = Resources.LoadAll("Deffenses",typeof(GameObject));
        Object[] offenses = Resources.LoadAll("Offenses", typeof(GameObject));
        Object[] levels   = Resources.LoadAll("Levels", typeof(GameObject));
        Object[] manas    = Resources.LoadAll("Manas", typeof(GameObject));

        foreach (Object deffense in defenses)
            Deffenses.Add(deffense as GameObject);

        foreach (Object offense in offenses)
            Offenses.Add(offense as GameObject);

        foreach (Object level in levels)
            Levels.Add(level as GameObject);

        foreach (Object mana in manas)
            Manas.Add(mana as GameObject);
    }

}
