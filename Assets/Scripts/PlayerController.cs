using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.EventSystems;
using System.Linq.Expressions;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 75f;
    public float zoomSpeed = 100;
    float rotationSpeed = 0.5f;

    float maxHeight = 180f;
    float minHeight = 30f;

    Vector2 p1;
    Vector2 p2;

    Ray ray;
    public Vector2 panLimit;
    private int yRot = 0;

    private void Start()
    {
    }

    private void Update()
    {
        Vector3 pos = transform.position;
        ray = GetComponentInChildren<Camera>().ScreenPointToRay(Input.mousePosition);

        if (Input.GetKey(KeyCode.W))
        {
            pos += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos += -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos += -transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos += transform.right * speed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * zoomSpeed * 100 * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, minHeight, maxHeight);
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

        transform.position = pos;

        GetCameraRotation();
}

void GetCameraRotation() 
    {
        if (Input.GetMouseButtonDown(2)) 
        {
            p1 = Input.mousePosition; 
        }

        if (Input.GetMouseButton(2)) 
        {
            p2 = Input.mousePosition;

            float dx = (p2 - p1).x * rotationSpeed;
            float dy = (p2 - p1).y * rotationSpeed;

            transform.rotation *= Quaternion.Euler(new Vector3(0, dx, 0));
            transform.GetChild(0).transform.rotation *= Quaternion.Euler(new Vector3(-dy, 0, 0));

            p1 = p2;
        }
    }

}
