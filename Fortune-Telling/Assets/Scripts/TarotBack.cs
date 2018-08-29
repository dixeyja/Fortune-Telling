using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarotBack : MonoBehaviour {

    public GameObject menu;

    private void OnMouseDown()
    {
        menu.SetActive(false);
    }
}
