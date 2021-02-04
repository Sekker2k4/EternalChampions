using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanOnLoadScene : MonoBehaviour
{
    public string tagJugador;
    public GameObject spawnOnloadPoint;

    void Start()
    {
        GameObject jugador = GameObject.FindGameObjectWithTag(tagJugador);

        jugador.transform.position = spawnOnloadPoint.transform.position;
    }
}
