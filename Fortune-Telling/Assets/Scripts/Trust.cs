using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Trust : MonoBehaviour {

    private int trustVal;
    public Text trustText;

	// Use this for initialization
	void Start () {
        trustVal = -1;
        trustText.text = "Trust: " + trustVal.ToString(); 
	}

    public void trustChange(int i)
    {
        trustVal = trustVal + i;
        trustText.text = "Trust: " + trustVal.ToString();
    }
	
}
