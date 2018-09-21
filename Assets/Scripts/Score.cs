﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    // Public variables visible in Unity
    public TextMesh displayText;

    // Private variables cant be touched by other scripts 
    private int currentValue = 0;

    // Update both the data value and the visual display
    public void ChangeValue(int _toChange)
    {
        currentValue = currentValue + _toChange;
        displayText.text = currentValue.ToString();

    }
    
    public void ResetScore()
    {

        currentValue = 0;
        displayText.text = currentValue.ToString();

    }


}
