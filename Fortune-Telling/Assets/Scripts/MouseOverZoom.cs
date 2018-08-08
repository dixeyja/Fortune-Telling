using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverZoom : MonoBehaviour {

    private Vector3 initScale;
    private Vector3 zoomScale;
    private bool isMouseOver = false;
    
    // Use this for initialization
	void Start () {
        initScale = transform.localScale;
        zoomScale = 1.2f * initScale;
	}

    private void Update()
    {
        
    }

    private void OnMouseOver()
    {
        transform.localScale = zoomScale;
    }

    private void OnMouseExit()
    {
        transform.localScale = initScale;
    }
}
