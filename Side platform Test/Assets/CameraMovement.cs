﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    [SerializeField]
    GameObject Player;
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y, -10);

    }
}