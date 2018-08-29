using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Trust : MonoBehaviour {

    private int trustVal;

	// Use this for initialization
	void Start () {
        trustVal = -1;
	}

    public void trustChange(int i)
    {
        trustVal = trustVal + i;
    }
	
}
