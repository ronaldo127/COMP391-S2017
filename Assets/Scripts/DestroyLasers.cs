﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLasers : MonoBehaviour {

    void OnTriggerExit2D(Collider2D collider) {
        Destroy(collider.gameObject);
    }
    
}
