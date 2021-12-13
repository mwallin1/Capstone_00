using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddGame : MonoBehaviour
{
    
    

    [SerializeField]
    private List<Button> answers = new List<Button>();

    [SerializeField]
    private GameObject question;

    private List<int> usedAnswers = new List<int>();

    private int aVal, bVal, cVal;
    private int hVal;

    private Button choice;

    

    public void changeAnswerValues() {
        int newValue = 0;
        
        for (int i = 0; i < answers.Count; i++){

            int rand = Random.Range(0, 100);

            if (rand < 50)
            {
                newValue = cVal + Random.Range(0, 3);
            }
            else {
                newValue = cVal - Random.Range(0, 3);
            }
            
            //makes it to where there are no duplicate answers
            if (usedAnswers.Contains(newValue)) {
                while (usedAnswers.Contains(newValue)) {
                    newValue = Random.Range((cVal-3),(cVal+3));
                }
            }
            answers[i].name = newValue.ToString();
            usedAnswers.Add(newValue);
            var txt = answers[i].GetComponentInChildren<TextMeshProUGUI>();
            
            txt.text = newValue.ToString();
        }
        if (!usedAnswers.Contains(cVal)) {
            int filler = Random.Range(0, 4);
            
            answers[filler].name = cVal.ToString();
            var txt2 = answers[filler].GetComponentInChildren<TextMeshProUGUI>();

            txt2.text = cVal.ToString();
        }
        usedAnswers.Clear();
    }

    public void changeQuestion() {
        aVal = Random.Range(1, 10);
        bVal = Random.Range(1, 10);
        hVal = Random.Range(1, 10);
        if (MenuManager.instance.hardMode == false)
        {
            cVal = aVal + bVal;
            question.GetComponent<TextMeshProUGUI>().text = aVal.ToString() + " + " + bVal.ToString() + " = ?";
        }
        else {
            cVal = aVal + bVal + hVal;
            question.GetComponent<TextMeshProUGUI>().text = aVal.ToString() + " + " + bVal.ToString() + " + " + hVal.ToString() + " = ?";
        }
        

        
    }

    public void OnClicked(Button button) {
        choice = button;
        
    }
    public void checkAnswers() {
        if (choice.name == cVal.ToString())
        {
            FindObjectOfType<SoundManager>().Play("Correct");
            changeQuestion();
            changeAnswerValues();
        }
        else {
            FindObjectOfType<SoundManager>().Play("Wrong");
        }
    }
}
