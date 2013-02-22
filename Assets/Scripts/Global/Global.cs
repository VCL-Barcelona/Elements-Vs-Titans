using UnityEngine;

public class Global : MonoBehaviour {

    public static Data data;
    public static Control control;
    public static View view;

	void Start () {

        DontDestroyOnLoad( gameObject );

        data    = GameObject.Find("DataManager").GetComponent<Data>   ();
        control = GameObject.Find("Controller") .GetComponent<Control>();
        view    = GameObject.Find("ViewManager").GetComponent<View>   ();
	}	
}
