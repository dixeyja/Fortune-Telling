using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueManager : MonoBehaviour {

    private Queue<string> sentences;
    private Dialogue dialogue;
    public Text mainText;
    public GameObject TextStop;
    public GameObject NextButton;
    

	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
        dialogue = GetComponent<DialogueTrigger>().dialogue;
        StartDialogue(dialogue);
        TextStop.SetActive(false);
        NextButton.SetActive(true);
	}
	
    public void StartDialogue (Dialogue dialogue)
    {

        Debug.Log("Conversation Commences");

        TextStop.SetActive(false);
        NextButton.SetActive(true);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }


    public void DisplayNextSentence()
    {
        if (sentences.Count == 1)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        mainText.text = sentence;
    }

    public void EndDialogue()
    {
        Debug.Log("end of convo");
        string sentence = sentences.Dequeue();
        mainText.text = sentence;
        TextStop.SetActive(true);
        NextButton.SetActive(false);
    }
}