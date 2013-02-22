using UnityEngine;
using System.Collections;

public class Gardener : MonoBehaviour {

    public GameObject[] plants;
    public GameObject selectedPlant;

    public void thisPlant(int i)
    {
        selectedPlant = plants[i];
    }

    public void thisSquare(Square square)
    {

        if (selectedPlant != null)
        {
            Vector3 Pos = new Vector3(square._x,0,square._z);
            Instantiate(selectedPlant, Pos, Quaternion.identity);
            selectedPlant = null;
        }
    }

}
