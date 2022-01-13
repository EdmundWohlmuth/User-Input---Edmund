using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxisRaw : MonoBehaviour
{
    float horizontalSpeed;
    float verticalSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalSpeed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.Translate(horizontalSpeed, 0, 0);

        verticalSpeed = Input.GetAxisRaw("Vertical") * Time.deltaTime;
        transform.Translate(0, 0, verticalSpeed);
    }
}
