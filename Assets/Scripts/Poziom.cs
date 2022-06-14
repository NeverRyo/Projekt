using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poziom : MonoBehaviour
{
    public string levelName;
    public TextMesh text;
    public GameObject Nike;

    void Start()
    {
        if (PlayerPrefs.GetInt(levelName + "_finished") == 0)
        {
            Destroy(Nike);
        }

        text.text = levelName;
    }

    void OnMouseDown()
    {
        Application.LoadLevel(levelName);
    }
}
