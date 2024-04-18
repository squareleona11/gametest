using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaMug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject teacupPrefab;     
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject teacup = Instantiate(teacupPrefab,transform.position, Quaternion.Euler(-90f,0f,90f))as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            teacup.GetComponent<TeaMugControll>().Shoot(worldDir.normalized * 2000);
        }
    }
}
