using UnityEngine;
using System.Collections.Generic;

public class MyPlayer : MonoBehaviour 
{
    public List<GameObject> arsenal;
    public int defensesToGo;
    public bool readyToGo;

	void Start () 
    {
        arsenal = new List<GameObject>();
        readyToGo = false;
	}

    public void AddDefense(GameObject defense)
    {
        if (arsenal.Count < defensesToGo && !arsenal.Contains(defense))
        {
            arsenal.Add(defense);
        }

        readyToGo = arsenal.Count == defensesToGo;
    }

    public void RemoveDefense(GameObject defense)
    {
        if (arsenal.Contains(defense))
            arsenal.Remove(defense);

        readyToGo = arsenal.Count == defensesToGo;
    }
}
