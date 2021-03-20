using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundImage : MonoBehaviour
{
    public Image image;

    public List<Sprite> bgList;

    private int total = 0;
    private void Awake()
    {
        InvokeRepeating("Change", 60f, 60f);
        total = bgList.Count;
    }

    private void Change()
    {
        int random = UnityEngine.Random.Range(0, total);
        image.sprite = bgList[random];
    }
}
