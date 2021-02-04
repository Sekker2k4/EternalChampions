using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
   public int nivel;

   public void OnClickButton()
    {
        Application.LoadLevel (1);
    }
}
