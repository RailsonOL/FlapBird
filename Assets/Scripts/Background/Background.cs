using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public MeshRenderer mR;
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        imageOffsetChange();
    }

    void imageOffsetChange(){
        mR.material.mainTextureOffset = new Vector2(Time.time * speed, 0); // Vector2 = x, y || Vector3 = xyz
    }
}
