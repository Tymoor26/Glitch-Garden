﻿using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.GetComponent<Attacker>()) {Destroy(col.gameObject);}
    }
}
