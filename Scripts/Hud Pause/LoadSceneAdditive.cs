using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAdditive : MonoBehaviour
{
    void Update()
    {

        //Whereas pressing this Button loads the Additive Scene.
        if (Input.GetKeyUp (KeyCode.Escape))
        {
            LoadPauseMenu();
        }
    }
    public void LoadPauseMenu()
    {
        SceneManager.LoadScene("HUD pause", LoadSceneMode.Additive);
    }
}
