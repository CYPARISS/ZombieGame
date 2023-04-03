using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GunController : MonoBehaviour
{
    int kill = 0;
    public Transform camera_transform;

    [SerializeField] TextMeshProUGUI TextKill;

    public ParticleSystem fire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            fire.Play();
            if(Physics.Raycast(camera_transform.position, transform.forward, out hit, 200f)){
                    if(hit.transform.gameObject.tag == "enemy1"){
                        hit.transform.gameObject.GetComponent<enemyhp>().hp--;
                        if(hit.transform.gameObject.GetComponent<enemyhp>().hp == 0){
                            hit.transform.gameObject.SetActive(false);
                            kill++;
                            TextKill.text = kill.ToString();
                        }
                    }
            }
        }
    }
}
