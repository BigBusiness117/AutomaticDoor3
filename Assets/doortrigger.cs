using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doortrigger : MonoBehaviour
{
    public GameObject door;
    public float speed = 1f;
    private bool doorOpen = false;
    private bool doorExit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        doorOpen = true;
        doorExit = false;
    }
    private void OnTriggerExit(Collider other)
    {

        doorExit = true;
    }


    // Update is called once per frame
    void Update()
    {
        if(doorOpen == true)
        {
            door.transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime );
            if(door.transform.position.y >= 9) 
            {
                doorOpen = false;
            }
        }
        if(doorExit == true)
        {
            doorOpen = false;
            door.transform.Translate(new Vector3(0, -speed, 0) * Time.deltaTime);
            if (door.transform.position.y <= 4.5)
            {
                doorExit = false;
            }
        }
        
    }
}
