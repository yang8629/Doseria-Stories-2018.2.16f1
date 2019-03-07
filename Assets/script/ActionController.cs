using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//角色行動的計算
//紀錄攻擊的方式與當前行動者
public class ActionController : MonoBehaviour {
    public static float[] character_timer;
    public int player_count;

    public class aaa
    {
        private int a;
        private int b;
        public aaa(int i, int t)
        {
            this.a = i;
            this.b = t;
        }
        public void setA(int i)
        {
            a = i;
        }
        public void show()
        {
            Debug.Log("a : " + this.a + " b : " + this.b + '\n');
        }
    }
    public aaa zxc=new aaa(29,30);

    void Awake()
    {
        zxc.show();
    }

    void Start()
    {
        zxc.setA(10);
        zxc.show();
    }

    void Timer()//行動值計算 根據角色靈敏值
    {
        if (BattleInfo.inbattle)//戰鬥中
        {
            for (int i = 0; i < player_count; i++)
            {
                //if (character_moving[i] == false && character_dead[i] == false)
                //{
                    character_timer[i] += Time.deltaTime * PlayerInfo.characters[i].AT.At;
                //}
            }
        }
    }
}
