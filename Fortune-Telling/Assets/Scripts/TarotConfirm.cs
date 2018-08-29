using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarotConfirm : MonoBehaviour {

    public GameObject thisMenu;
    public GameObject nextMenu;

    private void OnMouseDown()
    {
        nextMenu.SetActive(true);
        thisMenu.SetActive(false);
    }
}
