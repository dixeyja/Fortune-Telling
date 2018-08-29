using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;
    public GameObject item;
    public Camera cam;
    public GameObject itemDescrip;
    public GameObject itemOption1;
    public GameObject itemOption2;
    public GameObject backButton;
    public GameObject itemName;
    public int trustVal;
    public GameObject unlockOne;
    public GameObject unlockTwo;
 

    public void OnMouseDown()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);



        item.SetActive(false);
        itemDescrip.SetActive(false);
        itemOption1.SetActive(false);
        itemOption2.SetActive(false);
        backButton.SetActive(false);
        itemName.SetActive(false);

        //for opening new points of interest in a specific order
        if (unlockOne != null){
            unlockOne.SetActive(true);
            if (unlockTwo != null){
            unlockTwo.SetActive(true);
            }
        }

        FindObjectOfType<Trust>().trustChange(trustVal);
    }
}
