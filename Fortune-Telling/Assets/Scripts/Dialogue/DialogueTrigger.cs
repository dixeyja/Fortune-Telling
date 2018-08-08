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
    public GameObject itemLine;
    public GameObject itemName;
    public int trustVal;
 

    public void OnMouseDown()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

        cam.transform.position = item.GetComponent<ImportantItem>().GetInitPosition();
        cam.orthographicSize = item.GetComponent<ImportantItem>().GetInitZoom();

        item.SetActive(false);
        itemDescrip.SetActive(false);
        itemOption1.SetActive(false);
        itemOption2.SetActive(false);
        backButton.SetActive(false);
        itemLine.SetActive(false);
        itemName.SetActive(false);

        FindObjectOfType<Trust>().trustChange(trustVal);
    }
}
