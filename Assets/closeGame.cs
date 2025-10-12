using UnityEngine;

public class closeGame : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Spiel wird beendet...");

        #if UNITY_EDITOR
                // Spiel stoppen, wenn im Editor getestet
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                    // Spiel im Build schlieﬂen
                    Application.Quit();
        #endif
    }
}
