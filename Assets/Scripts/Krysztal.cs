using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Krysztal : MonoBehaviour
{
    public GameObject particle;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name != "sphere")
        {
            return;
        }

        int points = PlayerPrefs.GetInt("points");
        points += 1;
        PlayerPrefs.SetInt("points", points);

        if (leaveCrystals() == 1)
        {
            string levelName = Application.loadedLevelName;
            PlayerPrefs.SetInt(levelName + "_finished", 1);

            Application.LoadLevel("Menu");
        }
        else
        {
            GameObject.Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    int leaveCrystals()
    {
        Krysztal[] crystals = Component.FindObjectsOfType<Krysztal>();
        return crystals.Length;
    }
}
