using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesUI : MonoBehaviour
{
    public void Viajar()
    {
        Debug.Log("Bot�n Viajar presionado");
    }

    public void Galeria()
    {
        Debug.Log("Bot�n Galer�a presionado");
    }

    public void Salir()
    {
        Debug.Log("Bot�n Salir presionado");
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
