using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bag : MonoBehaviour
{
    public GameObject speechBubble;
    private bool isVisible = false;
    public Text speechText;
    public AudioSource soundSource;
    public AudioSource zipSound;

    private void OnMouseDown()
    {
        speechText.text = "Hobbys habe ich natürlich auch… also wenigstens ein paar.";
        isVisible = true;

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

        zipSound.Play();
    }

    private IEnumerator HideAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        speechBubble.SetActive(false);
        isVisible = false;
    }
}
