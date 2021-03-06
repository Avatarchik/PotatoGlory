﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    //保存当前分数
    public int score = 0;
    //获取PlayerControl脚本引用
    private PlayerControl playerControl;
    //保存上一个分数
    private int previousScore = 0;

    [SerializeField]
    private Text scoreText;

    private void Awake() {
        playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update () {
        scoreText.text = "Score: " + score;

        if(previousScore != score) {
            //得分之后启动嘲讽协程
            playerControl.StartCoroutine(playerControl.Taunt());
        }

        previousScore = score;
	}
}
