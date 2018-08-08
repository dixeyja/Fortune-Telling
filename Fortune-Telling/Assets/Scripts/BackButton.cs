using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {

    public ImportantItem item;
    public Camera cam;
    public GameObject itemDescrip;
    public GameObject itemOption1;
    public GameObject itemOption2;

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            cam.transform.position = item.GetInitPosition();
            cam.orthographicSize = item.GetInitZoom();
            gameObject.SetActive(false);
            itemDescrip.SetActive(false);
            itemOption1.SetActive(false);
            itemOption2.SetActive(false);
        }

    }
}
