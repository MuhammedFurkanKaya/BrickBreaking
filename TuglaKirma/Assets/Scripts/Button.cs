using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public void DigerSahne()
    {
        Tugla.toplamTuglaSayisi = 0;
        GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().PuanSifirla();
        SceneManager.LoadScene("Bolum1");
    }
}
