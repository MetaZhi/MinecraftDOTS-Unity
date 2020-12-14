﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolbarScript : MonoBehaviour {

    public int blockNum;
    public Transform Select;
    void Start()
    {
        Select = transform.GetChild(0);    
    }

    void Update () {
        if (Minecraft.PickaxeController.blockID == blockNum)
        {
            Select.GetComponent<RawImage>().enabled = true;
        }
        if (Minecraft.PickaxeController.blockID != blockNum)
        {
            Select.GetComponent<RawImage>().enabled = false;
        }
    }
}
