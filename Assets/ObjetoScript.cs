using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] objetos;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnButtonDown()
    {
        foreach (GameObject g in objetos)
        {
            g.SetActive(false);
        }
    }

}
