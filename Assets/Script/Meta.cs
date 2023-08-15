using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    public int escena;

    private void OnTriggerEnter2D(Collider2D collision)

    {
        SceneManager.LoadScene(escena);
    }
}
         