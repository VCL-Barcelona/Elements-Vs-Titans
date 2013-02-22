using UnityEngine;
using System.Collections;
public enum Element
{
    Earth,
    Aqua,
    Fire,
    Wind,
}
public class Defense : MonoBehaviour {

    public Element element;
    public int Price;
    public Texture2D img;
    public int Cooldown;

    void OnMouseDown()
    {
        GameObject player = GameObject.FindWithTag("Player");
        MyPlayer myPlayer = player.GetComponent<MyPlayer>();

        myPlayer.AddDefense(gameObject);
    }

}
