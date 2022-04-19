using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialogo_Manager : MonoBehaviour
{
    public Dialogo_Tutorial dialogo;

    Queue<string> sentences;

    public GameObject dialoguePanel;
    public TextMeshProUGUI displayText;

    string activeSentence;
    public float typingSpeed;

    private int presionado;


    void Start()
    {
        sentences = new Queue<string>();
        
    }

    void StartDialogue() 
    {
        sentences.Clear();
        foreach(string sentence in dialogo.sentenceList)
        {
            sentences.Enqueue(sentence);
        }
    }

    void DisplayNextSentence()
        {
            if(sentences.Count <= 0)
            {
            displayText.text = activeSentence;
            PlayerControl.mover = 1;
            return;
            }
       
            activeSentence = sentences.Dequeue();
            displayText.text = activeSentence;
            

        StopAllCoroutines();
        StartCoroutine(TypeTheSentence(activeSentence));

        }
    IEnumerator TypeTheSentence(string sentence)
    {
        displayText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            displayText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    
   private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            PlayerControl.mover = 0;
            dialoguePanel.SetActive(true);           
            StartDialogue();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            
            if (Input.GetKeyDown(KeyCode.Return))
            {
                presionado = 1;
                
            }
            if (Input.GetKeyUp(KeyCode.Return))
            {
                if(presionado == 1)
                {
                    DisplayNextSentence();
                    presionado = 0;
                }
                

            }
        }
    }
    private void OnTriggerExit2D(Collider2D obj)
    {
        if(obj.CompareTag("Player"))
        {
            dialoguePanel.SetActive(false);
            StopAllCoroutines();
            PlayerControl.mover = 1;    
        }
    }
}


