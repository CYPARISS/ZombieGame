using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour
{
    float mouseY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseY = mouseY -  Input.GetAxis("Mouse Y");
        mouseY = Mathf.Clamp(mouseY, -35f,35f);
        transform.localRotation = Quaternion.Euler(mouseY,0,0);
    }
}
