using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public int nivel;
    [SerializeField]
    private Image _progressBar;


    // Start is called before the first frame update
    void Start()
    {
        //start async operation
        StartCoroutine(LoadAsyncOperation());

    }

    IEnumerator LoadAsyncOperation()
    {
        //create async operation
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync (nivel);
        

        while (gameLevel.progress < 1)
        {
            //take the progress bar fill = async operation progress.
            _progressBar.fillAmount = gameLevel.progress;
            yield return new WaitForEndOfFrame();
        }
        
    }

 }
