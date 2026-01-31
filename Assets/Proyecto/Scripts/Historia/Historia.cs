using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Historia : MonoBehaviour
{
    public List<GameObject> historia = new List<GameObject>();
    public int contador = 0;

    private void Start()
    {
        if (historia.Count > 0)
        {
            historia[contador].SetActive(true);
        }
    }
    public void SeeNewText()
    {
        
        contador++;
    
        if (contador >= historia.Count)
        {
            SceneManager.LoadScene("InGame");
            return;
        }        
        foreach (GameObject go in historia)
        {
            go.SetActive(false);
        }
        historia[contador].SetActive(true);
    }
}
