using UnityEngine;
using System.Collections.Generic;

public class Builder : MonoBehaviour {

    public List<GameObject> platforms;
    public List<GameObject> defenses;

    void Start()
    {
        GameObject dataManager = GameObject.FindWithTag("DataManager");
        Data data = dataManager.GetComponent<Data>();

        Vector3 Pos = new Vector3(-7.5f,0,0);
        Quaternion Rot = Quaternion.identity;
        Rot.eulerAngles = new Vector3(-90, 0, 0);

        foreach (GameObject deffense in data.Deffenses)
        {
            Instantiate(deffense, Pos, Rot);
            Pos.x += 5;
        }
    }
}
