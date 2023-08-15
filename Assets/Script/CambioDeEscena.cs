using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    int escena;
    public void CambiarEscena(int escenaObejtivo)
    {
        escena = escenaObejtivo;
        Invoke("Cambio", 0.4f);
    }
    public void Cambio()
    {
        SceneManager.LoadScene(escena);
    }
}
