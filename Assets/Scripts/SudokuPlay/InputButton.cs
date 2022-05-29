using UnityEngine;


public class InputButton : MonoBehaviour
{
    public static InputButton instance;
    SudokuCell lastCell;
    [SerializeField] GameObject wrongText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void ActivateInputButton(SudokuCell cell)
    {
        //mli katkhetar cell les mafih 7ta number walakin nta baghi tktb fih number kayt2aficha clavier
        this.gameObject.SetActive(true);
        lastCell= cell;
    }

    public void ClickedButton(int num)
    {
        lastCell.UpdateValue(num);
        wrongText.SetActive(false);
        this.gameObject.SetActive(false);
        //hadi mli kadir click 3la chi number mn clavier dial numbers
    }



}
