using UnityEngine;

public class Square : MonoBehaviour
{
    public int _x;
    public int _y;
    public int _z;
    public GameObject gardener;

    public Square(int x, int y, int z)
    {
        _x = x;
        _y = y;
        _z = z;
    }

    void OnMouseDown()
    {
        gardener.GetComponent<Gardener>().thisSquare(this);
    }
}
