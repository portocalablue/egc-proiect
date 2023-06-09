using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public float mouseSensibility = 250f;

    public Transform playerBody;

    float Xrotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*mouseSensibility*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*mouseSensibility*Time.deltaTime;

        Xrotation -= mouseY;
        Xrotation=Mathf.Clamp(Xrotation, -90f, 90f);

        transform.localRotation=Quaternion.Euler(Xrotation,0,0);

        playerBody.Rotate(Vector3.up*mouseX);
    }
}
