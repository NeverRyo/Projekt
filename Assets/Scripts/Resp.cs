using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resp : MonoBehaviour
{
    public GameObject ballPrefab;
    public Camera cameraPrefab;
    public Light lightPrefab;
    public GameObject GameOver;
    public GameObject Level;
    void Start()
    {
        GameObject sphere = GameObject.Instantiate(ballPrefab);
        sphere.name = "sphere";
        sphere.transform.position = transform.position + Vector3.up * 2f;

        Camera camera = GameObject.Instantiate(cameraPrefab);
        KameraControler cameraController = camera.GetComponent<KameraControler>();
        cameraController.sphere = sphere.transform;

        Light light = GameObject.Instantiate(lightPrefab);


        GameObject.Instantiate(GameOver);
        GameObject.Instantiate(Level);
    }

    void Update()
    {
        
    }
}
