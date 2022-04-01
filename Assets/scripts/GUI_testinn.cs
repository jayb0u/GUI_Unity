using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_testinn : MonoBehaviour
{
    public Button btn1;
    public Toggle tgl1;
    public Slider sld1;
    public Dropdown ddn1;
    public InputField inf1;

    // Start is called before the first frame update
    void Start()
    {
        btn1.onClick.AddListener(btn1_Clicked);
        tgl1.onValueChanged.AddListener(tgl1_ValueChanged);
        sld1.onValueChanged.AddListener(sld1_ValueChanged);
        ddn1.onValueChanged.AddListener(ddn1_ValueChanged);
        inf1.onValueChanged.AddListener(inf1_ValueChanged);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void btn1_Clicked()
    {
        Debug.Log("Btn1 à été cliqué !");
    }

    void tgl1_ValueChanged(bool value)
    {
        Debug.Log($"Le toggle à une valeur {value}");
    }

    void sld1_ValueChanged(float value)
    {
        Debug.Log($"Le slider à une valeur {value}");
    }

    void ddn1_ValueChanged(int value)
    {
        Debug.Log($"L'index du ddn1 à une valeur {value}");
    }

    void inf1_ValueChanged(string value)
    {
        Debug.Log($"L'input à une valeur {value}");
    }
}
