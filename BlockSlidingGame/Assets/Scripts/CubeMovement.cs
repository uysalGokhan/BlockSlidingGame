using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    private Camera _mainCamera;
    private Renderer _renderer;

    private Ray _ray;
    private RaycastHit _hit;

    public int direction = 0;
    private float speed = 1.0f;
    private bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        _mainCamera = Camera.main;
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            if(direction == 0)
            {
                Vector3 movement = new Vector3(1, 0, 0);
                transform.Translate(movement * speed * Time.deltaTime);
            } else if(direction == 1)
            {
                Vector3 movement = new Vector3(0, 1, 0);
                transform.Translate(movement * speed * Time.deltaTime);
            } else
            {
                Vector3 movement = new Vector3(0, 0, 1);
                transform.Translate(movement * speed * Time.deltaTime);
            }
        } else
        {
            if (Input.GetMouseButtonDown(0))
            {
                _ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(_ray, out _hit, 1000f))
                {
                    if (_hit.transform == transform)
                    {
                        isMoving = true;
                        _renderer.material.color = _renderer.material.color == Color.red ? Color.blue : Color.red;
                    }
                }
            }
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        isMoving = false;
    }
}
