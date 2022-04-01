using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int levelID;

    //index du button attendu
    int buttonID = -1;

    public Text txtlevel;
    public Text txtessai;

    BtnDot[] buttons;

    float speed = 3f;
    int tentative = 10;
    float succesRate = 0.8f;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //modifier le texte de niveau
        txtlevel.text = levelID.ToString();

        //reset le texte d'essai
        txtessai.text = "0";

        //Initialiser le button array
        buttons = FindObjectsOfType<BtnDot>();

        //Assigner le id au button
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].AssignValue(i);
        }

        //modifier speed
        speed = speed - 0.3f * levelID;

        //Empecher le speed d'aller sous 0
        if (speed < 0.3f)
            speed = 0.3f;

        //Appeller le changement de button à tout les (speed) secondes
        InvokeRepeating("AssignButton", 3f, speed);
    }

    // Trouver un nouvel index
    void AssignButton()
    {
        int _random = buttonID;

        //modifier couleur du précédent button
        

        while (_random == buttonID)
        {
            _random = Random.Range(0, buttons.Length);
        }

        // Indiquer au button qu'il est le MVB(most valuable button)
        buttonID = _random;

        //modifier couleur du nouveau button
        buttons[buttonID].GetComponent<RawImage>().color = Color.green;
    }

    public void btnDot_Clicked(int _btnDotID)
    {
        //comparer les id
        if (_btnDotID == buttonID)
        {
            
            //modifier la couleur du button
            ResetButtonColor();
            //obtenir un point
            GamePoint();
            //si c'est le bon, modifie l'index attribu
            buttonID = -1;

            Debug.Log($"Le score est de {score} points");
        }

    }

    void GamePoint()
    {
        //obtenir un point
        score++;

        if (score > 3)
        {
            //stopper l'invoke
            CancelInvoke("AssignButton");
            //retourner a la scene principale
            SceneManager.LoadScene("mobile legend");
            //modifier la sauvegarde
            Messager.SetLevelCompleted(levelID);
        }
    }

    void ResetButtonColor()
    {
        if (buttonID > -1)
            buttons[buttonID].GetComponent<RawImage>().color = Color.white;
    }
}
