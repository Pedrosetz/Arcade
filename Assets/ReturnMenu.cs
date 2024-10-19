using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReturnMenu : MonoBehaviour
{
    private static bool instanciaCriada = false;

    void Awake()
    {
        if (!instanciaCriada)
        {
            DontDestroyOnLoad(gameObject); 
            instanciaCriada = true; 
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Tecla Esq pressionada");
            SceneManager.LoadScene("Main"); 
        }
    }
}
