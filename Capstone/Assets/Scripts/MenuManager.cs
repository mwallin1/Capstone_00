using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;
    public GameObject TitleScreen, GameMenu, AboutScreen, MemoryGame, MemoryGameBack,MemoryGameTitle, AddGame, SubGame,SpellGame, MultGame, DivGame;
    void Awake() {
        instance = this;
    }

    void update() {
       
    }

    public void titleScreenControl() {
        if (StateManager.instance.State == State.titleScreen) {
            TitleScreen.SetActive(true);
            GameMenu.SetActive(false);
            AboutScreen.SetActive(false);
            MemoryGame.SetActive(false);
            MemoryGameBack.SetActive(false);
            AddGame.SetActive(false);
            SubGame.SetActive(false);
            SpellGame.SetActive(false);
            MultGame.SetActive(false);
            DivGame.SetActive(false);
            MemoryGameTitle.SetActive(false);
        }
    }

    public void gameMenuControl()
    {
        if (StateManager.instance.State == State.gameMenu)
        {
            TitleScreen.SetActive(false);
            GameMenu.SetActive(true);
            AboutScreen.SetActive(false);
            MemoryGame.SetActive(false);
            MemoryGameBack.SetActive(false);
            AddGame.SetActive(false);
            SubGame.SetActive(false);
            SpellGame.SetActive(false);
            MultGame.SetActive(false);
            DivGame.SetActive(false);
            MemoryGameTitle.SetActive(false);
        }
    }

    public void aboutScreenControl() {
        if (StateManager.instance.State == State.aboutScreen) {
            TitleScreen.SetActive(false);
            GameMenu.SetActive(false);
            AboutScreen.SetActive(true);
            MemoryGame.SetActive(false);
            MemoryGameBack.SetActive(false);
            AddGame.SetActive(false);
            SubGame.SetActive(false);
            SpellGame.SetActive(false);
            MultGame.SetActive(false);
            DivGame.SetActive(false);
            MemoryGameTitle.SetActive(false);
        }
    }

    public void memGameControl() {
        if (StateManager.instance.State == State.memGame)
        {
            TitleScreen.SetActive(false);
            GameMenu.SetActive(false);
            AboutScreen.SetActive(false);
            MemoryGame.SetActive(true);
            MemoryGameBack.SetActive(true);
            AddGame.SetActive(false);
            SubGame.SetActive(false);
            SpellGame.SetActive(false);
            MultGame.SetActive(false);
            DivGame.SetActive(false);
            MemoryGameTitle.SetActive(true);
        }
    }

    public void addGameControl() {
        if (StateManager.instance.State == State.addGame) {
            TitleScreen.SetActive(false);
            GameMenu.SetActive(false);
            AboutScreen.SetActive(false);
            MemoryGame.SetActive(false);
            MemoryGameBack.SetActive(false);
            AddGame.SetActive(true);
            SubGame.SetActive(false);
            SpellGame.SetActive(false);
            MultGame.SetActive(false);
            DivGame.SetActive(false);
            MemoryGameTitle.SetActive(false);
        }
    }

    public void subGameControl()
    {
        if (StateManager.instance.State == State.subGame)
        {
            TitleScreen.SetActive(false);
            GameMenu.SetActive(false);
            AboutScreen.SetActive(false);
            MemoryGame.SetActive(false);
            MemoryGameBack.SetActive(false);
            AddGame.SetActive(false);
            SubGame.SetActive(true);
            SpellGame.SetActive(false);
            MultGame.SetActive(false);
            DivGame.SetActive(false);
            MemoryGameTitle.SetActive(false);
        }
    }
    
    public void multGameControl() {
        if (StateManager.instance.State == State.multGame)
        {
            TitleScreen.SetActive(false);
            GameMenu.SetActive(false);
            AboutScreen.SetActive(false);
            MemoryGame.SetActive(false);
            MemoryGameBack.SetActive(false);
            AddGame.SetActive(false);
            SubGame.SetActive(false);
            SpellGame.SetActive(false);
            MultGame.SetActive(true);
            DivGame.SetActive(false);
            MemoryGameTitle.SetActive(false);
        }
    }
 
    public void divGameControl() {
        if (StateManager.instance.State == State.divGame)
        {
            TitleScreen.SetActive(false);
            GameMenu.SetActive(false);
            AboutScreen.SetActive(false);
            MemoryGame.SetActive(false);
            MemoryGameBack.SetActive(false);
            AddGame.SetActive(false);
            SubGame.SetActive(false);
            SpellGame.SetActive(false);
            MultGame.SetActive(false);
            DivGame.SetActive(true);
            MemoryGameTitle.SetActive(false);
        }
    }


    public void spellGameControl() {
        if (StateManager.instance.State == State.spellGame)
        {
          
            TitleScreen.SetActive(false);
            GameMenu.SetActive(false);
            AboutScreen.SetActive(false);
            MemoryGame.SetActive(false);
            MemoryGameBack.SetActive(false);
            AddGame.SetActive(false);
            SubGame.SetActive(false);
            SpellGame.SetActive(true);
            MultGame.SetActive(false);
            DivGame.SetActive(false);
            MemoryGameTitle.SetActive(false);
        }
    }
}
