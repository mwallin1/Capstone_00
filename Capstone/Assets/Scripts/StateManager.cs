using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public static StateManager instance;
    public State State;

    void Awake() {
        instance = this;
    }

    void Start() {
        changeState(State.titleScreen);
        print(State);
    }

    public void changeState(State nextState) {
        State = nextState;

        switch (nextState) {
            case State.titleScreen:
                MenuManager.instance.titleScreenControl();
                break;
            case State.gameMenu:
                MenuManager.instance.gameMenuControl();
                break;
            case State.aboutScreen:
                MenuManager.instance.aboutScreenControl();
                break;
            case State.memGame:
                MenuManager.instance.memGameControl();
                break;
            case State.addGame:
                MenuManager.instance.addGameControl();
                break;
            case State.subGame:
                MenuManager.instance.subGameControl();
                break;
            case State.multGame:
                MenuManager.instance.multGameControl();
                break;
            case State.divGame:
                MenuManager.instance.divGameControl();
                break;
            case State.spellGame:
                MenuManager.instance.spellGameControl();
                break;

        }
    }

    public State getCurrentState() {
        return State;
    }
}

public enum State { 
    titleScreen = 0,
    gameMenu = 1,
    aboutScreen = 2,
    memGame = 3,
    addGame = 4,
    subGame = 5,
    multGame = 6,
    divGame = 7,
    spellGame = 8
}
