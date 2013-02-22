using UnityEngine;
using System.Collections.Generic;

public class Board : MonoBehaviour
{
    private int _dimx;
    private int _dimy;
    private GameObject[,] _grid;
    public GameObject Square;
    public GameObject gardener;

	// Use this for initialization
	void Start ()
	{
	    _dimx = 11;
	    _dimy = 5;

        _grid = new GameObject[_dimx,_dimy];

	    FillGrid();
	}

    private void FillGrid()
    {
        for (var i = 0; i < _dimx; i++)
        {
            for (var j = 0; j < _dimy; j++)
            {
                Vector3 Pos = new Vector3(i,0,j);

                GameObject square = (GameObject)Instantiate(Square, Pos, Quaternion.identity);

                Square sq = square.GetComponent<Square>();
                sq._x = i;
                sq._y = 0;
                sq._z = j;
                sq.gardener = gardener;

                if ((i + j)%2 == 0)
                {
                    square.renderer.material.color = Color.blue;
                }
                else
                {
                    square.renderer.material.color = i%2 == 0 ? Color.gray : Color.cyan;
                }
                _grid[i, j] = square;
            }
        }
    }
}
