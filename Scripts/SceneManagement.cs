using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public int nivel;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds (3.0f);
        SceneManager.LoadScene (nivel);
    }
}
