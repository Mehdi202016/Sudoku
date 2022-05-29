using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void ButtonStart()
    {
        SceneManager.LoadScene("Country");
    }

    public void ButtonQuit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
