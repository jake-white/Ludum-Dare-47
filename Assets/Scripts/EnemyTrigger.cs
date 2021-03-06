﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public Animator anim;
    public AudioClip revealSFX;
    public string reveal;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other) {
        if (other.tag == "MainCamera") {
            if (!anim.GetComponent<Enemy>().activated) {
                anim.Play(reveal);
                SFXController.instance.PlaySFX(revealSFX, 1, false);
            }
        }
    }
}
