using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Umschauen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

       
        Vector3 direction = mousePosition - transform.position;

      
        transform.up = direction.normalized;
    }
}
