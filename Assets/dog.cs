using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class dog : MonoBehaviour
{
    public GameObject speechBubble;
    private bool isVisible = false;
    public Text speechText;
    public AudioSource soundSource;

    private void OnMouseDown()
    {
        speechText.text = "Kann mir jemand sagen, wer hier eigentlich wen spazieren führt?";
        isVisible = true;
        speechBubble.SetActive(isVisible);
        soundSource.Play();
        Debug.Log("Gedrückt");
        StartCoroutine(HideAfterSeconds(5f));
    }


    private IEnumerator HideAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        speechBubble.SetActive(false);
        isVisible = false;
    }
}
