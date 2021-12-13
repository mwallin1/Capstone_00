using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Awesome Tuts youtube tuturiol
//https://www.youtube.com/watch?v=2ii0rPoiGkw

public class MemoryGame : MonoBehaviour
{
    public List<Button> btnList = new List<Button>();

   

    [SerializeField]
    private Transform memoryGame;

    [SerializeField]
    private GameObject btn;

    [SerializeField]
    private Sprite bgImage;

    public Sprite[] memImage;
    public List<Sprite> memList = new List<Sprite>();

    private bool firstGame = true;
    
    private bool firstGuess, secondGuess;
    private int firstGuessIndex, secondGuessIndex, matchedPairs;
    private string firstGuessString, secondGuessString;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    public void addButtons() {
        if (firstGame) {
            for (int i = 0; i < 12; i++)
            {
                GameObject button = Instantiate(btn);
                button.name = "" + i;
                button.transform.SetParent(memoryGame, false);
                firstGame = false;
            }
        }
        
    }

    public void getButtons() {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("memButton");
        print(firstGuess);
        print(secondGuess);
        for (int i = 0; i < objects.Length; i++)
        {
            btnList.Add(objects[i].GetComponent<Button>());
            btnList[i].interactable = true;
            btnList[i].image.sprite = bgImage;
        }

        

       

        
    }

    public void chooseButton() {
        
        
        if (!firstGuess) {
            firstGuess = true;
            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            firstGuessString = btnList[firstGuessIndex].name;
            print(firstGuessString);
            btnList[firstGuessIndex].image.sprite = memList[firstGuessIndex];
            secondGuess = false;

        }
        else if (!secondGuess){
            secondGuess = true;
            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            if (secondGuessIndex == firstGuessIndex) {
                secondGuess = false;
                return;
            }
            secondGuessString = btnList[secondGuessIndex].name;
            print(secondGuessString);
            btnList[secondGuessIndex].image.sprite = memList[secondGuessIndex];

            StartCoroutine(CheckIfMatch());
        }
        
    }

    public void addListeners() {
        foreach (Button btn in btnList) {
            btn.onClick.AddListener(() => chooseButton());
        }
    }
    public void assignMemSprites() {
        int looper = btnList.Count;
        int index = 0;

        for (int i = 0; i < looper; i++) {
            if (index == looper / 2) {
                index = 0;
            }

            memList.Add(memImage[index]);
            index++;
        }
        randomize(memList);
    }

    public void destroyButtons() {
        btnList.Clear();
        memList.Clear();
        firstGuess = false;
        secondGuess = true;
        
    }

    IEnumerator CheckIfMatch()
    {
        yield return new WaitForSeconds(1f);

        if (btnList[firstGuessIndex].image.sprite == btnList[secondGuessIndex].image.sprite)
        {
            yield return new WaitForSeconds(.5f);
            btnList[firstGuessIndex].interactable = false;
            btnList[secondGuessIndex].interactable = false;
            firstGuess = false;
            print(firstGuess);
            print(secondGuess);
        }

        else {
            yield return new WaitForSeconds(.5f);
            btnList[firstGuessIndex].image.sprite = bgImage;
            btnList[secondGuessIndex].image.sprite = bgImage;
            firstGuess = false;
            secondGuess = true;
            print(firstGuess);
            print(secondGuess);
        }
    }

    public void randomize(List<Sprite> list) {
        for (int i = 0; i < list.Count; i++) {
            Sprite temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}


