using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "sphere")
        {
            string levelName = Application.loadedLevelName;
            Application.LoadLevel(levelName);
        }
    }
}
