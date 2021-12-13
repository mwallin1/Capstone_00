using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonPress : MonoBehaviour
{
    public void pressButton()
    {
        FindObjectOfType<SoundManager>().Play("MenuButton");
        
    }
}
