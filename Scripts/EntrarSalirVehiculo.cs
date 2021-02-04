using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EntrarSalirVehiculo : MonoBehaviour
{

    public int nivel;




    void OnTriggerEnter(Collider infoacceso) {

        if (infoacceso.tag != "Player") return;


        Application.LoadLevel(nivel);
        // Application.SceneManager.LoadScene(nivel);
    }

}

