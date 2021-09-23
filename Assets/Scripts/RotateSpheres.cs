using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpheres : MonoBehaviour
{
    Vector3 movment;
    public int xi,yi,zi;
    // Start is called before the first frame update
    void Start()//executes at first frame
    {
        movment=new Vector3(xi,yi,zi);
        
    }

    // Update is called once per frame
    void Update()//executes at every frame
    {
        transform.Rotate(movment);
        
    }
}
