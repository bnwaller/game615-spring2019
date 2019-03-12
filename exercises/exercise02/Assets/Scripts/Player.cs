using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject SpherePrefab;

    float speed = 5f;
    float rotateSpeed = 200;
    // public GameObject target; 
    bool shouldRotate = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (shouldRotate)
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);

        }

        if (Input.GetKey(KeyCode.X))
        {
            GameObject Sphere = Instantiate(SpherePrefab, transform.position, transform.rotation);
            Destroy(Sphere, 20f);
        }
    }
    public void ChangeShouldRotate()
    {
        shouldRotate = !shouldRotate;

    }
}