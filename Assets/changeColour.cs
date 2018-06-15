using System;
using UnityEngine;
using UnityEngine.UI;

public class changeColour : MonoBehaviour
{
    private Button theButton;
    private ColorBlock theColor;
    int Value = 0;

    Color[] arrayColors = new Color[6];

    void Awake()
    {
        arrayColors[0] = Color.red;
        arrayColors[1] = Color.blue;
        arrayColors[2] = Color.green;
        arrayColors[3] = Color.yellow;
        arrayColors[4] = Color.black;
        arrayColors[5] = Color.magenta;

        theButton = GetComponent<Button>();
        theColor = GetComponent<Button>().colors;
    }

    public void changeThemColours()
    {
        theColor.highlightedColor = arrayColors[Value];
        theColor.normalColor = arrayColors[Value];

        theButton.colors = theColor;
        if (Value < 7)
        {
            Value++;
        }
        else
        {
            Value = 0;
        }
        
    }
}
