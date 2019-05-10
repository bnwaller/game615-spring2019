using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnClick : MonoBehaviour
{
    public float rayLength;
    public LayerMask layermask;
    public float speed = 50f;
    public CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {

    }

    void update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            characterController.Move(transform.forward * Time.deltaTime * 50f);
        }
        transform.Rotate(0, Input.GetAxis("Horizontal") * 5, 0);

        characterController.Move(new Vector3(0, Input.GetAxis("Vertical") * 2, 0));
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength, layermask))

            {
                Debug.Log(hit.collider.name);

            }
        }
    }
}


