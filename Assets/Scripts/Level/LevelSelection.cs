using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelSelection : MonoBehaviour
{
    [SerializeField] Button[] lvlButtons;

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("Country", 1);
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 1 > levelAt)
                lvlButtons[i].interactable = false;
        }
    }

    public void buttonBack()
    {
        SceneManager.LoadScene("Play");
    }

}
