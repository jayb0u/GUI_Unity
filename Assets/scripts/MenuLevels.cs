using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuLevels : MonoBehaviour
{
    public Button[] btnLevels;
    public Button btnlevel_1;
    public Button btnExit;

    // Start is called before the first frame update
    void Start()
    {
        btnlevel_1.onClick.AddListener(btnlevel1_Clicked);
        btnExit.onClick.AddListener(btnExit_Clicked);

        //vérifié la complétion des niveaux
        for (int i = 0; i < btnLevels.Length; i++)
        {
            if (Messager.save[i+1] == '1')
            {
                //Niveau est complété, on le rend accesible. 
                btnLevels[i].interactable = true;

                //Le niveau suivant est aussi accesible
                if (i+1 < btnLevels.Length)
                {
                    btnLevels[i+1].interactable = true;
                }
            }
        }
    }

    void btnlevel1_Clicked()
    {
        // Charger la scene Level-1
        SceneManager.LoadScene("Level-1");
    }

    void btnExit_Clicked()
    {
        //Fermeture de soi-même (menu des niveaux)
        gameObject.SetActive(false);
    }
}
