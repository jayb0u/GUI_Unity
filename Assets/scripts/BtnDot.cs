using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnDot : MonoBehaviour
{
    //contient l'identifiant du button 
    public int btnID;

    //Called by the game manager to assign an ID
    public void AssignValue(int _ID)
    {
        btnID = _ID;

        //event listener
        GetComponent<Button>().onClick.AddListener(btnDot_Clicked);
    }

    void btnDot_Clicked()
    {
        //Aviser le gamemanager
        FindObjectOfType<GameManager>().btnDot_Clicked(btnID);
    }
}
