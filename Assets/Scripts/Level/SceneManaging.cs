using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{
    [SerializeField] GameObject locked;
    [SerializeField] GameObject Notlocked;
    Button btn ;
    [SerializeField] int index;
    public static int index_country;


    private void Start()
    {
        btn = GetComponent<Button>();
    }
    public void showLevelsScene(string name)
    {
        index_country = index;
        //Debug.Log(index_country);
        SceneManager.LoadScene(name);
    }

    private void Update()
    {
        if (btn.interactable == true)
        {
            locked.SetActive(false);
            Notlocked.SetActive(true);
        }

    }
}
