using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{


    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.y, 0f);    
    }
}
