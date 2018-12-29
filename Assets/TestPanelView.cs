// **********************************************************************
// Copyright (C) 2018 EastHill Group .Co .Ltd
//
// 文件名(File Name):             TestPanelView.cs
// 作者(Author):                  #AuthorName#
// 创建时间(CreateTime):          #CreateTime#
// 修改者列表(modifier):
// 模块描述(Module description):
// **********************************************************************

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class TestPanelView : MonoBehaviour
{
    [SerializeField]
    private Button btn;

    [SerializeField]
    private Button btn2;

    [SerializeField]
    private Toggle tog;

    [SerializeField]
    private Dropdown drop;

    void Start()
    {
        EventTriggerListener.Get(btn.gameObject).onClick = OnBtnClick;
        EventTriggerListener.Get(btn2.gameObject).onClick = OnBtnClick;
        //btn.onClick.AddListener(BtnClick);
        tog.onValueChanged.AddListener(TogValueChanged);

        drop.onValueChanged.AddListener(dropValueChanged);

        drop.options.Clear();

        for(int i = 0; i < 10; i++)
        {
            Dropdown.OptionData item = new Dropdown.OptionData();
            item.text = "测试数据" + i;

            drop.options.Add(item);
        }
    }

    void OnBtnClick(GameObject go)
    {
        Debug.Log("GameObject="+ go.name);
    }

    private void TogValueChanged(bool arg0)
    {
        Debug.Log(tog.isOn);
    }

    private void BtnClick()
    {
        Debug.Log("点击按钮");
    }

    void dropValueChanged(int value)
    {
        Debug.Log(drop.options[value].text);
    }
}
