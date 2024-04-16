using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public float movementSpeed = 2.0f;
    public GameObject fireballPrefab;

    private GameObject instantiat;


    float castTime = 3;// for the first time activate a if statement
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 movement = Vector3.zero;

        if (Input.GetKey("d"))
        {
            movement += new Vector3(3.5f, 0, 0) ; // Vector3.right
         
        }
        if (Input.GetKey("a"))
        {
            movement -= new Vector3(3.5f, 0, 0);


        }
        if (Input.GetKey("w"))
        {
            movement += new Vector3(0, 3.5f, 0);
        }
        if (Input.GetKey("s"))
        {
            movement -= new Vector3(0, 3.5f, 0);
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeed = 3.0f;
        }else
            movementSpeed = 2.0f;



        castTime += Time.deltaTime;
        if (castTime >= 3 && Input.GetKeyDown("space"))
        {
            instantiat = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
            castTime = 0;

        }
 

        transform.position += movement.normalized * 3.5f * Time.deltaTime * movementSpeed;



        

    }
}
