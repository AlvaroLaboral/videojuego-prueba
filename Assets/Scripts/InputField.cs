using TMPro;
using UnityEngine;

public class InputFieldScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nombre;

    public void Entrada(string text)
    {
        nombre.text = "Bienvenido/a " + text;
    }

    public void play()
    {

        Debug.Log("se ha iniciado el juego");

    }
}