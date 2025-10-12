using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cup : MonoBehaviour
{
    public GameObject speechBubble;
    private bool isVisible = false;
    public Text speechText;
    public AudioSource soundSource;

    private void OnMouseDown()
    {
        speechText.text = "Die Tage werden wieder k�lter, zum Gl�ck habe ich meinen Tee.";
        isVisible = true;
        speechBubble.SetActive(isVisible);
        soundSource.Play();
        Debug.Log("Gedr�ckt");
        StartCoroutine(HideAfterSeconds(5f));
    }


    private IEnumerator HideAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        speechBubble.SetActive(false);
        isVisible = false;
    }

}
