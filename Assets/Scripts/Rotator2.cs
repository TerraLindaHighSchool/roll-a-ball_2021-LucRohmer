using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator2 : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
    }
}
