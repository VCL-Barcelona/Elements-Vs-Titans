using UnityEngine;
using System.Collections.Generic;

public enum GUIMode
{
    Menu,
    LevelSelector,
    Inventory,
    Level,
    Lobby,
}

public class View : MonoBehaviour {

    
    public GUIMode guiMode;
    public int numLevels;
    public int columns;
    public int columnSize;
    public Vector2 scrollPosition;
    public int offset;
    public MyPlayer player;
    public Data data;

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));

        switch (guiMode)
        {
            case GUIMode.Menu:

                paintMenu();
                break;

            case GUIMode.LevelSelector:

                paintLevelSelector();
                break;

            case GUIMode.Inventory:

                paintInventory();
                break;

            case GUIMode.Level:

                paintLevel();
                break;

            case GUIMode.Lobby:

                paintLobby();
                break;
        }

        GUILayout.EndArea();
    }

    private void paintMenu()
    {
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();

        if (GUILayout.Button("New Game"))
        {
            Application.LoadLevel(Application.loadedLevel + 1);
            guiMode = GUIMode.Inventory;
        }
        if (GUILayout.Button("Select Level"))
        {
            Application.LoadLevel(3);
            guiMode = GUIMode.LevelSelector;
        }
        if (GUILayout.Button("Options"))
        {
            Debug.Log("ChooseOptions();");
        }
        if (GUILayout.Button("Load Data"))
        {
            GameObject dm = GameObject.FindWithTag("DataManager");
            dm.GetComponent<Data>().Load();
        }
        if (GUILayout.Button("Exit"))
        {
            Application.Quit();
        }

        GUILayout.FlexibleSpace();
        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
    }

    private void paintLevelSelector()
    {
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();

        scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(columns*columnSize+offset), GUILayout.Height(columns*columnSize+offset));
        
        for (int i = 0; i <= numLevels/columns; i++)
        {
            GUILayout.BeginHorizontal();

            for (int j = 0; j < columns; j++)
            {
                int level = i*columns + j + 1;

                if (level <= numLevels)
                {
                    if (GUILayout.Button("Level " + level, GUILayout.Width(columnSize), GUILayout.Height(columnSize)))
                    {
                        Debug.Log("Level" + level);
                    }
                }
            }
            
            GUILayout.EndHorizontal();
        }
        
        GUILayout.EndScrollView();

        GUILayout.FlexibleSpace();
        if (GUILayout.Button("Exit Game",GUILayout.Height(columnSize)))
        {
            Application.Quit();
        }
        GUILayout.FlexibleSpace();

        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
    }

    public void paintInventory()
    {
        GUILayout.BeginHorizontal();

        List<GameObject> arsenal = player.arsenal;

        for (int i = 0; i < arsenal.Count; i++)
        {
            GameObject go = arsenal[i];
            Defense defense = go.GetComponent<Defense>();

            if (GUILayout.Button(defense.img,GUILayout.Width(columnSize),GUILayout.Height(columnSize)))
            {
                player.RemoveDefense(go);
            }
        }

        GUI.enabled = player.readyToGo;

        if (GUILayout.Button("GO!",GUILayout.Width(columnSize),GUILayout.Height(columnSize)))
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }

        GUI.enabled = true;

        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
    }

    public void paintLevel()
    {
        GUILayout.BeginHorizontal();
        /*
        for (int i = 0; i < manaTextures.Length; i++)
        {
            if (GUILayout.Button(manaTextures[i]))
            {
                Debug.Log("Mana" + i);
            }
        }
        for (int i = 0; i < deffenseTextures.Length; i++)
        {
            if (GUILayout.Button(deffenseTextures[i]))
            {
                Debug.Log("Deffense" + i);
            }
        }
        */
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
    }

    public void paintLobby()
    {
        GUILayout.Label("Lobby");
    }
}
