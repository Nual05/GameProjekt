using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    private float xPos = 0;
    private float yPos = 0;
    private float fireballTime = 3;
    Vector3 dist; 

    Quaternion change;



    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f); // Zerstörung von Feuerball nach 3 Sekunde
        dist = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

       

        if (fireballTime >= 3)
        {
            if (Input.GetKey("a"))
            {
                if (Input.GetKey("w"))
                {

                    change = Quaternion.Euler(0, 0, 145);
                    xPos = -10;
                    yPos = 10;
                    fireballTime = 0;
                }else if (Input.GetKey("s"))
                {
                    change = Quaternion.Euler(0, 0, -145);
                    xPos = -10;
                    yPos = -10;
                    fireballTime = 0;
                }
                else
                {
                    change = Quaternion.Euler(0, 0, 180); // Change Rotation
                    yPos = 0;
                    xPos = -10;
                    fireballTime = 0;
                    

                }

            }

            else if (Input.GetKey("w"))
            {
                if (Input.GetKey("d"))
                {
                    change = Quaternion.Euler(0, 0, 45);
                    xPos = 10;
                    yPos = 10;
                    fireballTime = 0;
                }
                else{
                    change = Quaternion.Euler(0, 0, 90);
                    xPos = 0;
                    yPos = 10;
                    fireballTime = 0;

                }


            }
            else if (Input.GetKey("s"))
            {
                if (Input.GetKey("d"))
                {
                    change = Quaternion.Euler(0, 0, -45);
                    xPos = 10;
                    yPos = -10;
                    fireballTime = 0;
                }
                else
                {
                    change = Quaternion.Euler(0, 0, -90);
                    xPos = 0;
                    yPos = -10;
                    fireballTime = 0;
                }
                
            }
            else
            {
                xPos = 10;
                fireballTime = 0; // If no press key is default value
            }
        }

        if(change!= null)
            transform.rotation = change;

        Vector3 vector = transform.position - dist;
        Debug.Log(vector);

        fireballTime += Time.deltaTime;
        transform.position += new Vector3(xPos, yPos, 0) * Time.deltaTime;







    }


}
