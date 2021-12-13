using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToSpellGame : MonoBehaviour
{
    public void goSpell()
    {
        StateManager.instance.changeState(State.spellGame);
    }
}
