using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopTrigger : MonoBehaviour
{

    private void OnTriggerEnter (Collider other)
    {
        Debug.Log ("Triggered");
        Debug.Log ("Basketball_Rim.001.");


        GetComponent <AudioSource>().Play();


    }

}
