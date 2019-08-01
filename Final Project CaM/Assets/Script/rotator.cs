using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
   public int rSpeed;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate (new Vector3 (0, 0, rSpeed) * Time.deltaTime, Space.World);  
    }
}
