using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class csv : MonoBehaviour
{
    public TextAsset csvFile;

    void Awake()
    {

        List<Dictionary<string, object>> data = CSVReader.Read(csvFile.text);

        for (var i = 0; i < data.Count; i++)
        {
            print("name " + data[i]["name"] + " " +
                   "age " + data[i]["age"] + " " +
                   "speed " + data[i]["speed"] + " " +
                   "desc " + data[i]["description"]);
        }

    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}

