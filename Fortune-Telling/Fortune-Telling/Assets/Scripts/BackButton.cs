using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {

    public ImportantItem item;
    public Camera cam;

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            cam.transform.position = item.GetInitPosition();
            cam.orthographicSize = item.GetInitZoom();
        }
    }
}
