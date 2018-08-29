using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject menu;

    private void OnMouseDown()
    {
        menu.SetActive(true);
    }
}
