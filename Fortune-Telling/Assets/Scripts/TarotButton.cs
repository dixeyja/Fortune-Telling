using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TarotButton : MonoBehaviour {

    public SpriteRenderer trust;
    public Sprite yellow;
    public Sprite green;

    public GameObject tarotConfirm;

    private void OnMouseDown()
    {
        if(trust.sprite == green || trust.sprite == yellow)
        {
            tarotConfirm.SetActive(true);
        }
    }
}
