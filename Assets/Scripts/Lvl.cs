using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl : MonoBehaviour
{
    public TextMesh LevelTekst;

    void Start()
    {
        string Level = Application.loadedLevelName;
        LevelTekst.text = Level;
    }
}