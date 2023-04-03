using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vaccine : MonoBehaviour
{
    public Dictionary<string, float>[] array = new Dictionary<string, float>[3];
    // Start is called before the first frame update
    void Start()
    {
        array[0] = new Dictionary<string, float>();
        array[0].Add("x", 28.45f);
        array[0].Add("z", 18.65f);

        array[1] = new Dictionary<string, float>();
        array[1].Add("x", 18.34f);
        array[1].Add("z", -1.94f);

        array[2] = new Dictionary<string, float>();
        array[2].Add("x", -12.53f);
        array[2].Add("z", 10.05f);

        int index = Random.Range(0,2);
        transform.position = new Vector3(array[index]["x"], 0.96f, array[index]["z"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
