using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockIn : MonoBehaviour {

    public GameObject option1;
    public GameObject option2;

    public GameObject backButton;

    private void OnMouseOver()
    {
        if(Input.GetMouseButton(0))
        {
            option1.SetActive(true);
            option2.SetActive(true);
            backButton.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
