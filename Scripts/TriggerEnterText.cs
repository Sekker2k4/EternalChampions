//Jorge Ivorra Agulló///
///Eternal Champions////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerEnterText : MonoBehaviour
{
    public GameObject canvas;
   //añadir variable de audio

    public void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
        //audio
    }

    public void OnTriggerExit(Collider other)
    {
        canvas.SetActive(false);
        Destroy(this);
    }
}
