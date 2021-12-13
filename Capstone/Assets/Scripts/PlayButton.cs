using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void readyToPlay() {
        StateManager.instance.changeState(State.gameMenu);
    }
}
