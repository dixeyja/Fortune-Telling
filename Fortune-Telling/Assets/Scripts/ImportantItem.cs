using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantItem : MonoBehaviour {

    private Vector3 initScale;
    private Vector3 zoomScale;

    public GameObject objLine;
    public GameObject objName;
    public GameObject objDescrip;
    public GameObject optionOne;
    public GameObject optionTwo;
    public GameObject backButton;

    public Camera cam;

    public Transform targetPos;
    public float targetZoom;

    private Vector3 initPosition;
    private float initZoom;

    // Use this for initialization
    void Start()
    {
        objLine.SetActive(false);
        objName.SetActive(false);
        objDescrip.SetActive(false);
        optionOne.SetActive(false);
        optionTwo.SetActive(false);
        backButton.SetActive(false);
        initScale = transform.localScale;
        zoomScale = 1.2f * initScale;
        initPosition = cam.transform.position;
        initZoom = cam.orthographicSize;
    }

    public Vector3 GetInitPosition()
    {
        return initPosition;
    }

    public float GetInitZoom()
    {
        return initZoom;
    }

    private bool IsZoomed()
    {
        if(initZoom != cam.orthographicSize)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnMouseOver()
    {
        transform.localScale = zoomScale;
        objLine.SetActive(true);
        objName.SetActive(true);
        if(Input.GetMouseButton(0))
        {
            cam.transform.position = targetPos.position;
            cam.orthographicSize = targetZoom;
            backButton.SetActive(true);
            objDescrip.SetActive(true);
            optionOne.SetActive(true);
            optionTwo.SetActive(true);

        }
    }

    private void OnMouseExit()
    {
        transform.localScale = initScale;
        if(!IsZoomed())
        {
            objLine.SetActive(false);
            objName.SetActive(false);
        }
    }
}
