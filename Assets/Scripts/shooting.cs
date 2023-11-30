using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Camera cam;

    private Ray ray;
    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("PEW");
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag.Equals("NPC")) 
                {
                    Debug.Log("cube killer");
                    Destroy(hit.collider.gameObject);
                }
                else
                {
                    Debug.Log("how did you miss");
                }
            }
        }
    }
}
