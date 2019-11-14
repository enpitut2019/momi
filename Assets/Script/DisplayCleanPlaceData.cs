﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCleanPlaceData : MonoBehaviour
{
    CleanPlaceData myData;
    [SerializeField] Text lastUpdateTime;
    [SerializeField] Text intervalTime;

    /// <summary>
    /// 表示するデータの登録
    /// </summary>
    /// <param name="data"></param>
    public void SetCleanPlaceData(CleanPlaceData data)
    {
        myData = data;
    }

    /// <summary>
    /// データをテキストに表示する関数
    /// </summary>
    public void DisplayData()
    {
        if (myData != null)
        {
            lastUpdateTime.text = myData.LastUpdateTimeText;
            intervalTime.text = myData.CleanIntervalText;
        }
    }
}
