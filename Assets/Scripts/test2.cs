using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class test2 : MonoBehaviour
{
    [SerializeField] StatusSO statusSO;

    [SerializeField] TextMeshProUGUI console_txt;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        console_txt.GetComponent<TextMeshProUGUI>().text = statusSO.ATK.ToString()+"こうげきした！";
        
        
    }
}