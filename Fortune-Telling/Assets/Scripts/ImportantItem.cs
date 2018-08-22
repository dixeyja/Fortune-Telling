using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantItem : MonoBehaviour {

    private Vector3 initScale;
    private Vector3 zoomScale;

    
    public GameObject objName;
    public GameObject objDescrip;
    public GameObject optionOne;
    public GameObject optionTwo;
    public GameObject backButton;
    public GameObject lockIn;


    // Use this for initialization
    void Start()
    {
        objName.SetActive(false);
        objDescrip.SetActive(false);
        optionOne.SetActive(false);
        optionTwo.SetActive(false);
        backButton.SetActive(false);
        lockIn.SetActive(false);
        initScale = transform.localScale;
        zoomScale = 1.2f * initScale;
    }

    private void OnMouseOver()
    {
        transform.localScale = zoomScale;
        objName.SetActive(true);
        if(Input.GetMouseButton(0))
        {
            backButton.SetActive(true);
            objDescrip.SetActive(true);
            lockIn.SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        transform.localScale = initScale;
        if(backButton.activeSelf == false)
        {
            objName.SetActive(false);
        }
    }
}
