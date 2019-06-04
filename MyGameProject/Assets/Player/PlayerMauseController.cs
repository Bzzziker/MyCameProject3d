using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMauseController : MonoBehaviour
{
    [SerializeField]
    GameObject target_point;

    [SerializeField]
    GameObject ActivObject;  //Активный объект 

    [SerializeField]
    GameObject information_text;  //Информационный текст =/

    public int one;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _raycast();
         
        }


    }

    void _raycast()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out hit);

        if (hit.collider.tag == null) one++;
        if ((hit.collider.tag == "Characters") || (hit.collider.tag == "Infrastructure"))
        {
            ActivObject = hit.collider.gameObject;

        }
        if (ActivObject.tag == "Characters")
        {
            if(hit.collider.tag == "Enemy")
            {
                ActivObject.GetComponent<PlayerCharacterContoller>().Attack(hit.collider.gameObject);
            }
            else
            ActivObject.GetComponent<PlayerCharacterContoller>().welk(hit.point);
        }
        
        if(hit.collider!=null)
        {
            //information_text.GetComponent<TextMesh>().text = "asdasdasdasd";
           // information_text.GetComponent<TMPro>().text = "asdasdasdasd";
            information_text.GetComponent<TextMeshPro>().text = hit.collider.gameObject.name;
            information_text.gameObject.transform.position = new Vector3(hit.point.x,hit.point.y+3,hit.point.z);
        }
    }

    
}
