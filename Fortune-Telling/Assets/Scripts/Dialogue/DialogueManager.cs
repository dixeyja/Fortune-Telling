using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueManager : MonoBehaviour {

    private Queue<string> sentences;
    private Dialogue dialogue;
    public Text mainText;
    

	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
        dialogue = GetComponent<DialogueTrigger>().dialogue;
        StartDialogue(dialogue);
	}
	
    public void StartDialogue (Dialogue dialogue)
    {

        Debug.Log("Conversation Commences");

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }


    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
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
    }
}