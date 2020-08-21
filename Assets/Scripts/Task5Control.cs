using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using TMPro;

public class Task5Control : MonoBehaviour
{
    private float efficiency = 1f;
    private float ActiveTime = 0f;
    private bool Status = false; //false is idle, true is active
    private GameObject TMP1;
    private GameObject TMP2;
    private GameObject TMP3;
    [SerializeField] private GameObject TextContainer;


    // Start is called before the first frame update
    void Start()
    {
        TMP1 = TextContainer.transform.Find("TMP1").gameObject;
        TMP2 = TextContainer.transform.Find("TMP2").gameObject;
        TMP3 = TextContainer.transform.Find("TMP3").gameObject;

        
    }

    // Update is called once per frame
    void Update()
    {

        efficiency = 1 / Time.time;
        TMP2.GetComponent<TextMeshProUGUI>().text = "Total Time: " + (int)Time.time + "Sec.";
        TMP3.GetComponent<TextMeshProUGUI>().text = "Current Status: Idle" ;
        TMP1.GetComponent<TextMeshProUGUI>().text = "Efficiency: " + efficiency + "%";
    }
}
