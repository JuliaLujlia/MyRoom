using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cup : MonoBehaviour
{
    public GameObject speechBubble;
    private bool isVisible = false;
    public Text speechText;
    public AudioSource soundSource;
    public AudioSource drinkingSound;

    private void OnMouseDown()
    {
        speechText.text = "Die Tage werden wieder kälter, zum Glück habe ich meinen Tee.";
        isVisible = true;
        speechBubble.SetActive(isVisible);
        // Starte Coroutine, um Sounds nacheinander abzuspielen
        StartCoroutine(PlaySoundsSequentially());

        Debug.Log("Gedrückt");
        StartCoroutine(HideAfterSeconds(5f));
    }

    private IEnumerator PlaySoundsSequentially()
    {
        soundSource.Play();

        // Warte, bis soundSource fertig ist
        yield return new WaitWhile(() => soundSource.isPlaying);

        drinkingSound.Play();
    }



    private IEnumerator HideAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        speechBubble.SetActive(false);
        isVisible = false;
    }

}
