using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enemyhp : MonoBehaviour
{
    public int hp = 3;

    [SerializeField] TextMeshPro ENEMYHP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ENEMYHP.text = hp.ToString();
    }
}
