using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 10.0f))
            {
                if(hit.transform)
                {
                    PrintName(hit.transform.gameObject);
                    CurrentClickedGameObject(hit.transform.gameObject);
                }   
            }
        }
    }

    private void CurrentClickedGameObject(GameObject go)
    {
        if(go.tag == "SliCyl")
        go.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
    private void PrintName(GameObject go)
    {
        Debug.Log(go.name);
    }
}
