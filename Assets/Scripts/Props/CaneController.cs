using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaneController : MonoBehaviour
{
    public float speed = 2f;
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void FixedUpdate(){
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
