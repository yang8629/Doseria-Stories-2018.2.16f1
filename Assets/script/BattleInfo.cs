using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//紀錄戰鬥畫面中的資訊
//紀錄血量
public class BattleInfo {
    public static bool inbattle = true;

    public static List<float> enemies_hp = new List<float>();//敵人血量
    public static List<float> characters_hp = new List<float>();//角色血量

    
    public static void Reset()//Reset BattleInfo
    {

    }
}
