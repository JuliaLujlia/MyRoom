using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pc : MonoBehaviour
{
    public GameObject speechBubble;
    private bool isVisible = false;
    public Text speechText;
    public AudioSource soundSource;

    private void OnMouseDown()
    {
        speechText.text = "Wenn ich nicht im Bett bin, dann wahrscheinlich am PC.";
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
