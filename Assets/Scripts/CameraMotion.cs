using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour
{

    private float _speed;
    private float _rotationAngle;
    private float _r;
    private float rotationSpeed = 0.01f;
    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        _speed = 1f;
        _rotationAngle = 0f;
        _r = 0f;
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            _speed += 0.25f;
        }else if (Input.GetKey(KeyCode.S))
        {
            _speed -= 0.25f;

        }

        //float v = Input.GetAxis("Vertical");
        float mx = Input.GetAxis("Mouse X");
        print(mx);
        _r += mx * rotationSpeed;
        transform.Rotate(new Vector3(0, _r, 0));
        //transform.Translate(transform.forward * Time.deltaTime * _speed);
        //transform.Translate(Vector3.forward);

        Vector3 vector = transform.TransformDirection(Vector3.forward * Time.deltaTime * _speed);
        characterController.Move(vector);
        //transform.Translate(transform.right * Time.deltaTime * _speed);



    }
}
