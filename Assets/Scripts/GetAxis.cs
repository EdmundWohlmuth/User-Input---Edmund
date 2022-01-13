using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxis : MonoBehaviour
{
    float verticalSpeed;
    float horizontalSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        verticalSpeed = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(0, 0, verticalSpeed);

        horizontalSpeed = Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.Translate(horizontalSpeed, 0, 0);
    }
}
