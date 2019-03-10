using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//角色行動的計算
//紀錄攻擊的方式與當前行動者
public class ActionController : MonoBehaviour {
    public int player_count;

    void Awake()
    {

    }

    void Start()
    {
        player_count = BattleInfo.characterInbattle.Count;
    }

    void Timer()//行動值計算 根據角色靈敏值
    {
        if (BattleInfo.inbattle)//戰鬥中
        {
            for (int i = 0; i < player_count; i++)
            {
                //if (character_moving[i] == false && character_dead[i] == false)
                //{
                    BattleInfo.characterInbattle[i].Timer += Time.deltaTime * BattleInfo.characterInbattle[i].At;
                //}
            }
        }
    }
}
