using UnityEngine;
using System.Collections.Generic;

public class ElementPlatform : MonoBehaviour
{

    public Element _name;
    public float deltared;
    public float deltagreen;
    public float deltablue;
    public List<GameObject> Defenses;

    void OnMouseOver()
    {
        renderer.material.color -= new Color(deltared, deltagreen, deltablue) * Time.deltaTime;
    }

    public void AddDefense(GameObject ob)
    {
        Defenses.Add(ob);
    }

    public void Build()
    {
        Vector3 origin = this.transform.position + new Vector3(-1, 0, -1);

        for (int i = 0; i < Defenses.Count; i++)
        {
            Instantiate(Defenses[i], origin + new Vector3((i % 2) * 2, 0, (i / 2) * 2), Quaternion.identity);
        }
    }

}


