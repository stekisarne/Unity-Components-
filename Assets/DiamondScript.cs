using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    public int myValue;
    public SpriteRenderer ren;
    public Color newColor;
    [Range(-720, 720)]
    public float rotationSpeed;
    // Use this for initialization
    void Start()
    {
        //ren.color = newColor;
        ren.color = new Color(1f, 0.23f, 0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(5 * Time.deltaTime, 0, 0, Space.Self);
        }
        
    }
}
