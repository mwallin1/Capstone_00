using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpellGame : MonoBehaviour
{
    [SerializeField]
    private Image img;

    [SerializeField]
    private List<Button> answers = new List<Button>();

    public List<Sprite> imageList = new List<Sprite>();
    private List<int> usedIndex = new List<int>();

    private Button choice;

    private string imgName;

    private int index;




    public void setImage() {
        index = Random.Range(0, imageList.Count);
        img.sprite = imageList[index];
    }

    public void OnClicked(Button button)
    {
        choice = button;
    }

    public void changeAnswerValues()
    {


        switch (index)
        {
            case 0:
                var txt = answers[0].GetComponentInChildren<TextMeshProUGUI>();
                answers[0].name = "Strwberry";
                txt.text = answers[0].name;

                txt = answers[1].GetComponentInChildren<TextMeshProUGUI>();
                answers[1].name = "Strawberry";
                txt.text = answers[1].name;

                txt = answers[2].GetComponentInChildren<TextMeshProUGUI>();
                answers[2].name = "Strawbery";
                txt.text = answers[2].name;

                txt = answers[3].GetComponentInChildren<TextMeshProUGUI>();
                answers[3].name = "Strwberri";
                txt.text = answers[3].name;

                break;

            case 1:
                txt = answers[0].GetComponentInChildren<TextMeshProUGUI>();
                answers[0].name = "Tomato";
                txt.text = answers[0].name;

                txt = answers[1].GetComponentInChildren<TextMeshProUGUI>();
                answers[1].name = "Tamato";
                txt.text = answers[1].name;

                txt = answers[2].GetComponentInChildren<TextMeshProUGUI>();
                answers[2].name = "Tameto";
                txt.text = answers[2].name;

                txt = answers[3].GetComponentInChildren<TextMeshProUGUI>();
                answers[3].name = "Toumato";
                txt.text = answers[3].name;

                break;

            case 2:
                txt = answers[0].GetComponentInChildren<TextMeshProUGUI>();
                answers[0].name = "Watermelon";
                txt.text = answers[0].name;

                txt = answers[1].GetComponentInChildren<TextMeshProUGUI>();
                answers[1].name = "Watrmelon";
                txt.text = answers[1].name;

                txt = answers[2].GetComponentInChildren<TextMeshProUGUI>();
                answers[2].name = "Watermellon";
                txt.text = answers[2].name;

                txt = answers[3].GetComponentInChildren<TextMeshProUGUI>();
                answers[3].name = "Waturmelon";
                txt.text = answers[3].name;

                break;

            case 3:
                txt = answers[0].GetComponentInChildren<TextMeshProUGUI>();
                answers[0].name = "Lyme";
                txt.text = answers[0].name;

                txt = answers[1].GetComponentInChildren<TextMeshProUGUI>();
                answers[1].name = "Liem";
                txt.text = answers[1].name;

                txt = answers[2].GetComponentInChildren<TextMeshProUGUI>();
                answers[2].name = "Lihm";
                txt.text = answers[2].name;

                txt = answers[3].GetComponentInChildren<TextMeshProUGUI>();
                answers[3].name = "Lime";
                txt.text = answers[3].name;

                break;

            case 4:
                txt = answers[0].GetComponentInChildren<TextMeshProUGUI>();
                answers[0].name = "Blueberry";
                txt.text = answers[0].name;

                txt = answers[1].GetComponentInChildren<TextMeshProUGUI>();
                answers[1].name = "BluBerry";
                txt.text = answers[1].name;

                txt = answers[2].GetComponentInChildren<TextMeshProUGUI>();
                answers[2].name = "Blueberri";
                txt.text = answers[2].name;

                txt = answers[3].GetComponentInChildren<TextMeshProUGUI>();
                answers[3].name = "Bluebehri";
                txt.text = answers[3].name;

                break;

            case 5:
                txt = answers[0].GetComponentInChildren<TextMeshProUGUI>();
                answers[0].name = "Lemun";
                txt.text = answers[0].name;

                txt = answers[1].GetComponentInChildren<TextMeshProUGUI>();
                answers[1].name = "Lemon";
                txt.text = answers[1].name;

                txt = answers[2].GetComponentInChildren<TextMeshProUGUI>();
                answers[2].name = "Limon";
                txt.text = answers[2].name;

                txt = answers[3].GetComponentInChildren<TextMeshProUGUI>();
                answers[3].name = "Lehmon";
                txt.text = answers[3].name;

                break;

            case 6:
                txt = answers[0].GetComponentInChildren<TextMeshProUGUI>();
                answers[0].name = "Orange";
                txt.text = answers[0].name;

                txt = answers[1].GetComponentInChildren<TextMeshProUGUI>();
                answers[1].name = "Orunge";
                txt.text = answers[1].name;

                txt = answers[2].GetComponentInChildren<TextMeshProUGUI>();
                answers[2].name = "Oranje";
                txt.text = answers[2].name;

                txt = answers[3].GetComponentInChildren<TextMeshProUGUI>();
                answers[3].name = "Ohrunje";
                txt.text = answers[3].name;

                break;

            case 7:
                txt = answers[0].GetComponentInChildren<TextMeshProUGUI>();
                answers[0].name = "Carot";
                txt.text = answers[0].name;

                txt = answers[1].GetComponentInChildren<TextMeshProUGUI>();
                answers[1].name = "Carrut";
                txt.text = answers[1].name;

                txt = answers[2].GetComponentInChildren<TextMeshProUGUI>();
                answers[2].name = "Karrot";
                txt.text = answers[2].name;

                txt = answers[3].GetComponentInChildren<TextMeshProUGUI>();
                answers[3].name = "Carrot";
                txt.text = answers[3].name;

                break;



        }
    }

    public void checkAnswers() {
        if (choice.name == "Strawberry" || choice.name == "Tomato" || choice.name == "Watermelon" || choice.name == "Lime" || choice.name == "Blueberry" || choice.name == "Lemon" || choice.name == "Orange" || choice.name == "Carrot")
        {
            FindObjectOfType<SoundManager>().Play("Correct");
            setImage();
            changeAnswerValues();
        }
        else
        {
            FindObjectOfType<SoundManager>().Play("Wrong");
        }
    
    }
}
