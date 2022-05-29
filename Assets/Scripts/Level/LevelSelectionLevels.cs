using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectionLevels : MonoBehaviour
{
    [SerializeField] Button[] lvlButtons;

    void Start()
    {
        Debug.Log(SceneManaging.index_country);
        //nzid index country 7da NameSave
        //NameSave = Level / IndexCountry = 1 : CountriesLevels1
        //index kiji mn scene l scene
        int levelAt = PlayerPrefs.GetInt("CountriesLevels" + SceneManaging.index_country, 1);
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 1 > levelAt)
                lvlButtons[i].interactable = false;
        }

        //Debug.Log(PlayerPrefs.GetInt(NameSave));
        
    }

    public void buttonBack()
    {
        SceneManager.LoadScene("Country");
    }
}
