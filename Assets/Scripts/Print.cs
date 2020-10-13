using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SmartDLL;
using UnityEngine.UI;

public class Print : MonoBehaviour
{
    public SmartPrinter smartPrinter = new SmartPrinter();

    public InputField inputField;
    public Button printButton;
    string headerDir;
    private void OnEnable()
    {
        headerDir = Application.dataPath + "/HeaderTemplete.png";
        printButton.onClick.AddListener(() => { PrintDocument(); });
    }

    void PrintDocument() {
        smartPrinter.PrintDocument(inputField.text, headerDir);
    }
    // "C:\Users\f8704\OneDrive\Escritorio\Print unity\SmartPrinter\PSD Files\HeaderTemplete.png"
}
