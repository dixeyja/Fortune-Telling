using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {

    public ImportantItem item;
    public GameObject itemDescrip;
    public GameObject itemOption1;
    public GameObject itemOption2;
    public GameObject itemName;
    public GameObject lockIn;

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
            itemName.SetActive(false);
            itemDescrip.SetActive(false);
            itemOption1.SetActive(false);
            itemOption2.SetActive(false);
            lockIn.SetActive(false);
        }

    }
}
