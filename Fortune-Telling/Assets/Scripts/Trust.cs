using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Trust : MonoBehaviour {

    private int trustVal;
    public Text trustText;
    public GameObject trustDisplay;
    private SpriteRenderer trustUI;

    public Sprite red;
    public Sprite yellow;
    public Sprite green;

    // Use this for initialization
    void Start()
    {
        trustVal = -1;
        trustText.text = "Trust: ";
        trustUI = trustDisplay.GetComponent<SpriteRenderer>();
    }

    public void trustChange(int i)
    {
        trustVal = trustVal + i;
        trustText.text = "Trust: ";
        if (trustVal > 0)
        {
            trustUI.sprite = green;
        }
        else if (trustVal == 0)
        {
            trustUI.sprite = yellow;
        }
        else
        {
            trustUI.sprite = red;
        }
    }

}
