using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScenes : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(this.gameObject.scene.buildIndex + 1);
    }

    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(this.gameObject.scene.buildIndex - 1);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
