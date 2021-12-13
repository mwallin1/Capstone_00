using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DivGame : MonoBehaviour
{
    [SerializeField]
    private List<Button> answers = new List<Button>();

    [SerializeField]
    private GameObject question;

    private List<float> usedAnswers = new List<float>();

    private float aVal, bVal, cVal;

    private Button choice;



    public void changeAnswerValues()
    {
        float newValue = 0;

        for (int i = 0; i < answers.Count; i++)
        {

            int rand = Random.Range(0, 100);

            if (rand < 50)
            {
                newValue = cVal + Random.Range(0, 6);
                
            }
            else
            {
                newValue = cVal - Random.Range(0, 6);
                
            }

            //makes it to where there are no duplicate answers
            if (usedAnswers.Contains(newValue))
            {
                while (usedAnswers.Contains(newValue))
                {
                    newValue = Random.Range((cVal - 10), (cVal + 10));
                }
            }
            answers[i].name = newValue.ToString("F2");
            usedAnswers.Add(newValue);
            var txt = answers[i].GetComponentInChildren<TextMeshProUGUI>();

            txt.text = newValue.ToString("F2");
        }
        if (!usedAnswers.Contains(cVal))
        {
            int filler = Random.Range(0, 4);

            answers[filler].name = cVal.ToString("F2");
            var txt2 = answers[filler].GetComponentInChildren<TextMeshProUGUI>();

            txt2.text = cVal.ToString("F2");
        }
        usedAnswers.Clear();
    }

    public void changeQuestion()
    {
        aVal = Random.Range(1, 100);
        bVal = Random.Range(1, 10);
        if ((double)(aVal / bVal) % 2 == 0)
        {
            cVal = aVal / bVal;
            
        }
        else {
            while ((aVal / bVal) % 2 == 1) {
                aVal = Random.Range(1, 101);
                bVal = Random.Range(1, 11);
            }
            print((aVal / bVal));
            cVal = aVal / bVal;
            
        }

        

        question.GetComponent<TextMeshProUGUI>().text = aVal.ToString() + " / " + bVal.ToString() + " = ?";
    }

    public void OnClicked(Button button)
    {
        choice = button;

    }
    public void checkAnswers()
    {
        if (choice.name == cVal.ToString("F2"))
        {
            FindObjectOfType<SoundManager>().Play("Correct");
            changeQuestion();
            changeAnswerValues();
        }
        else
        {
            FindObjectOfType<SoundManager>().Play("Wrong");
        }
    }
}
