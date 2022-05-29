using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagingLevels : MonoBehaviour
{
    [SerializeField] GameObject locked;
    [SerializeField] GameObject Number;
    Button btn;

    [SerializeField] int index;
    public static int index_Level;

    [SerializeField] int difficulty_value;


    [SerializeField] int level_title_index;
    public static int level_title_index_level;



    //ndir so3oba dial level f kola button dial level w ga3 les buttons kaydiw l nefs scene les hia sudoku game
    private void Start()
    {
        btn = GetComponent<Button>();
    }
    public void ShowLevel()
    {
        //show Game
        index_Level = index;
        //Debug.Log(index_country);
        SceneManager.LoadScene("SudokuPlay");
        PlayerSettings.difficulty = difficulty_value;
        Debug.Log("Difficulty : " + PlayerSettings.difficulty);

        level_title_index_level = level_title_index;
    }
    private void Update()
    {
        if (btn.interactable == true)
        {
            locked.SetActive(false);
            Number.SetActive(true);
        }
        //
 

    }
}
