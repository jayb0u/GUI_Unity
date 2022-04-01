using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMain : MonoBehaviour
{
    public Button btnPlay;
    public GameObject menulevels;
    // Start is called before the first frame update
    void Start()
    {
        menulevels.SetActive(false);
        btnPlay.onClick.AddListener(btnPlay_Clicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void btnPlay_Clicked()
    {
        //Apparition du menu des niveaux
        menulevels.SetActive(true);
    }
}
