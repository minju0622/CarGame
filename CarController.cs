using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float cMvSpeed = 30.0f;
    float cRotSpeed = 150.0f;
    /*private bool jump;
    public float jumpVelocity = 5.0f;*/


    // Start is called before the first frame update
    void Start()
    {
        //jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mv = Input.GetAxis("Vertical") * cMvSpeed * Time.deltaTime;
        float rot = Input.GetAxis("Horizontal") * cRotSpeed * Time.deltaTime;

        transform.Translate(0, 0, mv);
        transform.Rotate(0, rot, 0);

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }*/

    }

    /*void FixedUpdate()
    {
        if (jump)
        {
            rigidbody.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
            jump = false;
        }
    }*/
}
