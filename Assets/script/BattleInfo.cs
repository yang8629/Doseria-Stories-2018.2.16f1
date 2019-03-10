using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//紀錄戰鬥畫面中的資訊
//紀錄血量
public class BattleInfo {
    public static bool inbattle = true;
    public static List<EnemyInbattle> enemyInbattle = new List<EnemyInbattle>();//敵人資料
    public static List<CharacterInbattle> characterInbattle = new List<CharacterInbattle>();//角色資料

    public class CharacterInbattle
    {
        public GameObject characterObj;
        public float Timer = 0;
        public float Hp;
        public float Ag;
        public float At;
        public bool Dead = false;
    }

    public void SetCharacterInbattle(GameObject characterObj, float Timer, float Hp, float Ag, float At)
    {
        CharacterInbattle buffer = new CharacterInbattle();
        buffer.characterObj = characterObj;
        buffer.Hp = Hp;
        buffer.Ag = Ag;
        buffer.At = At;
        characterInbattle.Add(buffer);
    }

    public class EnemyInbattle
    {
        public GameObject enemyObj;
        public float Timer = 0;
        public float Hp;
        public float Ag;
        public float At;
        public bool Dead = false;
    }

    public static void Reset()//Reset BattleInfo
    {
        enemyInbattle.Clear();
        characterInbattle.Clear();
    }
}
