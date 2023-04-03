using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

//движение через character controller, время, hp.
public class BodyContr : MonoBehaviour
{
    bool touch = false;
    int Playerhp = 100;
    [SerializeField] TextMeshProUGUI HP;
    [SerializeField] GameObject WIN;
    [SerializeField] GameObject LOSE;
    float vertical;
    float mouseX;

    void Start()
    {

        
    }
   
    void Update()
    {
        touch = false;
        vertical = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X");
        transform.Translate(0,0,1 * vertical * Time.deltaTime *10f, Space.Self);
        transform.Rotate(0,mouseX,0);

    }

    void OnCollisionEnter(Collision hit){
        if(hit.gameObject.tag == "Vaccine"){
            Destroy(hit.gameObject, 1f/2);
            WIN.SetActive(true);
        }

        if(hit.gameObject.tag == "enemy1" && touch == false){
            touch = true;
            Playerhp = Playerhp - 25;
            HP.text = "HP: " + Playerhp.ToString();
            if(Playerhp <= 0){
                LOSE.SetActive(true);
            }
        }
    }
}
