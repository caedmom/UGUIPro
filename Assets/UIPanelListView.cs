// **********************************************************************
// Copyright (C) 2018 EastHill Group .Co .Ltd
//
// 文件名(File Name):             UIPanelListView.cs
// 作者(Author):                  #AuthorName#
// 创建时间(CreateTime):          #CreateTime#
// 修改者列表(modifier):
// 模块描述(Module description):
// **********************************************************************

using UnityEngine;
using System.Collections;

public class UIPanelListView : MonoBehaviour
{
    private GameObject itemPrefab;

    [SerializeField]
    private GameObject Grid;

    void Start()
    {
        itemPrefab = Resources.Load("UI/Item") as GameObject;

        if(itemPrefab != null)
        {
            for(int i = 0; i < 20; i++)
            {
                GameObject obj = Instantiate(itemPrefab) as GameObject;
                obj.transform.parent = Grid.transform;
                obj.transform.localScale = Vector3.one;
                obj.transform.localPosition = Vector3.zero;
            }
        }
    }
}
