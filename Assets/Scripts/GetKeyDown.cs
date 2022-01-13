using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyDown : MonoBehaviour
{
    float speed;
    public GameObject getKeyDown;

    // Start is called before the first frame update
    void Start()
    {
        speed = 50;
    }

    // Update is called once per frame
    void Update()
    {
        //GetKeyDown
        if (Input.GetKeyDown(KeyCode.W))
        {
            getKeyDown.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            getKeyDown.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            getKeyDown.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            getKeyDown.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
