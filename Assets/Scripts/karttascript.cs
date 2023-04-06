using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karttaScript : MonoBehaviour
{
    public GameObject kamera = null;
    public GameObject kamera2 = null;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            this.kamera.GetComponent<Camera>().enabled = false;
            this.kamera2.GetComponent<Camera>().enabled = true;

        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            this.kamera.GetComponent<Camera>().enabled = true;
            this.kamera2.GetComponent<Camera>().enabled = false;

        }
    }
}
