using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using TMPro;


//20200819 Based on feedback from Johnson, I will rewrite this script so that it reads video file and corresponding configuration file.


public class TextControl : MonoBehaviour
{

    [SerializeField] private GameObject TextContainer;
    [SerializeField] private VideoPlayer VideoPlayer;
    private GameObject TMP1;
    private GameObject TMP2;
    private GameObject TMP3;
    private GameObject TMP4;

    private float StartTime;
    [SerializeField] private float Step1TimeStamp = 30f;
    [SerializeField] private float Step2TimeStamp = 50f;
    [SerializeField] private float Step3TimeStamp = 70f;
    [SerializeField] private float Step4TimeStamp = 90f;
    [SerializeField] private float Step5TimeStamp = 90f;

    Texture2D myTexture;

    private bool enable = false;
    // Start is called before the first frame update

    void Start()
    {
        TMP1 = TextContainer.transform.Find("TMP1").gameObject;
        TMP2 = TextContainer.transform.Find("TMP2").gameObject;
        TMP3 = TextContainer.transform.Find("TMP3").gameObject;
        TMP4 = TextContainer.transform.Find("TMP4").gameObject;
        

        TMP1.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>1. Loading";
        TMP2.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>2. Hauling";
        TMP3.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>3. Dumping";
        TMP4.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>4. Returns To Load";

    }

   /* 
    * void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 50), "Press Space to start.");
    }
    

    void OnGUI()
    {
        GUIStyle guiStyle = new GUIStyle(GUI.skin.label);
        guiStyle.fontSize = 36;
        guiStyle.normal.textColor = Color.white;
        //Load and set Font
        Font myFont = (Font)Resources.Load("Fonts/AMERICANCAPTAINWEBFONT", typeof(Font));
        guiStyle.font = myFont;
        guiStyle.alignment = TextAnchor.MiddleCenter;

        var message = "Press Spacebar to start.";
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200f, 200f), message,guiStyle);

    }
    */

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            VideoPlayer.Play();
            StartTime = Time.time;
            enable = true;
        }

            if (enable)
        {
            if (Time.time - StartTime < Step1TimeStamp)
            {
                TMP1.GetComponent<TextMeshProUGUI>().text = "<mark=#ffff00aa><b><color=#000000>1. Loading</b></mark>";

                myTexture = Resources.Load("Images/1") as Texture2D;
                GameObject rawImage = GameObject.Find("BirdsView");
                rawImage.GetComponent<RawImage>().texture = myTexture;
            }
            else if (Time.time - StartTime < Step2TimeStamp)
            {
                TMP1.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>1. Loading";
                TMP2.GetComponent<TextMeshProUGUI>().text = "<mark=#ffff00aa>2. Hauling</mark>";

                myTexture = Resources.Load("Images/3") as Texture2D;
                GameObject rawImage = GameObject.Find("BirdsView");
                rawImage.GetComponent<RawImage>().texture = myTexture;
            }
            else if (Time.time - StartTime < Step3TimeStamp)
            {
                TMP1.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>1. Loading";
                TMP2.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>2. Hauling";
                TMP3.GetComponent<TextMeshProUGUI>().text = "<mark=#ffff00aa>3. Dumping</mark>";

                myTexture = Resources.Load("Images/2") as Texture2D;
                GameObject rawImage = GameObject.Find("BirdsView");
                rawImage.GetComponent<RawImage>().texture = myTexture;
            }
            else if (Time.time - StartTime < Step4TimeStamp)
            {
                TMP1.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>1. Loading";
                TMP2.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>2. Hauling";
                TMP3.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>3. Dumping";
                TMP4.GetComponent<TextMeshProUGUI>().text = "<mark=#ffff00aa>4. Returns To Load</mark>";

                myTexture = Resources.Load("Images/4") as Texture2D;
                GameObject rawImage = GameObject.Find("BirdsView");
                rawImage.GetComponent<RawImage>().texture = myTexture;
            }
            else if (Time.time - StartTime < Step5TimeStamp)
            {
                TMP1.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>1. Loading";
                TMP2.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>2. Hauling";
                TMP3.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>3. Dumping";
                TMP4.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>4. Returns To Load";

                myTexture = Resources.Load("Images/5") as Texture2D;
                GameObject rawImage = GameObject.Find("BirdsView");
                rawImage.GetComponent<RawImage>().texture = myTexture;
            }
            else
            {
                //reset all text
                TMP1.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>1. Loading";
                TMP2.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>2. Hauling";
                TMP3.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>3. Dumping";
                TMP4.GetComponent<TextMeshProUGUI>().text = "<alpha=#88>4. Returns To Load";
            }
        }

    }

}
