using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Grid : MonoBehaviour {

    public GameObject grid;
    public GameObject canvas;
    public List<GameObject> grids = new List<GameObject>();
    int rows = 16;
    int columns = 9;
    int gridInt = 1;
    string output;

    void Start()
    {
        StreamReader reader = File.OpenText("Assets/StreamingAssets/levelOne.txt");
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] items = line.Split('\t');
            gridInt = int.Parse(items[4]);

            output = "1";
            foreach (string item in items)
            {
                if (item.StartsWith("1"))
                {
                    output = item;
                    Debug.Log(item);
                }
            }
        }
    }
}

