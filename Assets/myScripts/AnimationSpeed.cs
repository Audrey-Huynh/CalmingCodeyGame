using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeed : MonoBehaviour
{
    public Animator heartbeat_anim;
    // Start is called before the first frame update
    void Start()
    {
        heartbeat_anim.speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
