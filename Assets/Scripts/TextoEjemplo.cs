using UnityEngine;

public class TextoEjemplo : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI texto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Entrando en el juego");
        texto.text = "Mi videojuego";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
