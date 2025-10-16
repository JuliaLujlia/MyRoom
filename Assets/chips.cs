using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class chips : MonoBehaviour
{
    public GameObject speechBubble;
    private bool isVisible = false;
    public Text speechText;
    public AudioSource soundSource;
    public AudioSource chipsSound;

    private void OnMouseDown()
    {
        speechText.text = "Jeder, der mich kennt, weiß: Ohne Chips läuft hier nix.";
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

        chipsSound.Play();
    }


    private IEnumerator HideAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        speechBubble.SetActive(false);
        isVisible = false;
    }
}
