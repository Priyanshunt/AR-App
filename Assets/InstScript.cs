using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstScript : MonoBehaviour
{
    public GameObject parent;
    string btnName;
    // Start is called before the first frame update
    void Start()
    {
        parent.transform.GetChild(0).gameObject.SetActive(false);
        parent.transform.GetChild(2).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0 && Input.touches[0].phase==TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                btnName = hit.transform.name;
                switch(btnName)
                {
                    case "Left_Arrow":
                        if (parent.transform.GetChild(1).gameObject.activeSelf)
                        {
                            parent.transform.GetChild(0).gameObject.SetActive(true);
                            parent.transform.GetChild(1).gameObject.SetActive(false);
                            parent.transform.GetChild(3).gameObject.SetActive(false);
                        }
                        else
                        {
                            parent.transform.GetChild(1).gameObject.SetActive(true);
                            parent.transform.GetChild(2).gameObject.SetActive(false);
                            parent.transform.GetChild(4).gameObject.SetActive(true);
                        }
                        break;
                    case "Right_Arrow":
                        if (parent.transform.GetChild(1).gameObject.activeSelf)
                        {
                            parent.transform.GetChild(2).gameObject.SetActive(true);
                            parent.transform.GetChild(1).gameObject.SetActive(false);
                            parent.transform.GetChild(4).gameObject.SetActive(false);
                        }
                        else
                        {
                            parent.transform.GetChild(1).gameObject.SetActive(true);
                            parent.transform.GetChild(0).gameObject.SetActive(false);
                            parent.transform.GetChild(3).gameObject.SetActive(true);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
