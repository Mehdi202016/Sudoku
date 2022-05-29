using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // hadi khass ikon fiha ra9m dial index les m7lol les l3ab fih w rb7to 
    int nextLevelLoad;
    int nextCountryLoad;

    int nextLevelLoadSceneManage;

    public Text TextLevel;
    public Text TextLevelWin;
    //public Text ButtonText;

    public static GameManager instance;

    private void Awake()
    {
        if (this == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        //nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        nextLevelLoad = SceneManagingLevels.index_Level + 1;
        nextCountryLoad = SceneManaging.index_country + 1;


        nextLevelLoadSceneManage = SceneManagingLevels.level_title_index_level+1;



        Debug.Log("index level:" + SceneManagingLevels.index_Level);
    }

    public void ButtonNextLevel()
    {
        Time.timeScale = 1;
        //Debug.Log("okokok");
        if (SceneManagingLevels.index_Level ==  10)
        {
            if (nextCountryLoad > PlayerPrefs.GetInt("Country"))
            {
                PlayerPrefs.SetInt("Country", nextCountryLoad);
            }
            //ButtonText.text = "New";
            SceneManager.LoadScene("Country");
        }
       else
        {
            if (nextLevelLoad > PlayerPrefs.GetInt("CountriesLevels" + SceneManaging.index_country))
            {
                PlayerPrefs.SetInt("CountriesLevels" + SceneManaging.index_country, nextLevelLoad);
                //TextLevel.text = "Level " + nextLevelLoad.ToString();
            }
            
            if (nextLevelLoadSceneManage > 1 & nextLevelLoadSceneManage <= 10)
            {
                SceneManager.LoadScene("Levels1");
            }
            if (nextLevelLoadSceneManage > 10 & nextLevelLoadSceneManage <= 20)
            {
                SceneManager.LoadScene("Levels2");
            }
            if (nextLevelLoadSceneManage > 20 & nextLevelLoadSceneManage <= 30)
            {
                SceneManager.LoadScene("Levels3");
            }
            if (nextLevelLoadSceneManage > 30 & nextLevelLoadSceneManage <= 40)
            {
                SceneManager.LoadScene("Levels4");
            }
            if (nextLevelLoadSceneManage > 40 & nextLevelLoadSceneManage <= 50)
            {
                SceneManager.LoadScene("Levels5");
            }
            if (nextLevelLoadSceneManage > 50 & nextLevelLoadSceneManage <= 60)
            {
                SceneManager.LoadScene("Levels6");
            }
            if (nextLevelLoadSceneManage > 60 & nextLevelLoadSceneManage <= 70)
            {
                SceneManager.LoadScene("Levels7");
            }
            if (nextLevelLoadSceneManage > 70 & nextLevelLoadSceneManage <= 80)
            {
                SceneManager.LoadScene("Levels8");
            }
            if (nextLevelLoadSceneManage > 80 & nextLevelLoadSceneManage <= 90)
            {
                SceneManager.LoadScene("Levels9");
            }
            if (nextLevelLoadSceneManage > 90 & nextLevelLoadSceneManage <= 100)
            {
                SceneManager.LoadScene("Levels10");
            }


        }

        if (SceneManaging.index_country == 10)
        {
            SceneManager.LoadScene("Country");
        }

    }

    public void buttonBack()
    {
        SceneManager.LoadScene("Country");
    }
    private void Update()
    {
        if (SceneManagingLevels.index_Level == 10)
        {
            //ButtonText.text = "New";
        }

        Debug.Log("PlayerSettings.difficulty :"+ PlayerSettings.difficulty);
        TextLevel.text = "Level " + SceneManagingLevels.level_title_index_level.ToString();
        TextLevelWin.text = "Level " + SceneManagingLevels.level_title_index_level.ToString();
    }
}
