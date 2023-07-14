using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialogueManager : MonoBehaviour
{
    public Queue<string> sentences;


    private void Awake()
    {
        
    }

    private void Update()
    {
        if(Input.GetButtonDown("Interact"))
        {
            Debug.Log("AAAA");
        }
    }





    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);


        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }

    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
    }

    void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }
}
