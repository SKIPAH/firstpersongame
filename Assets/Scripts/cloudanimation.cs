using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudanimation : MonoBehaviour
{
    

   
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 1f);
        
    }
}
