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
        GameObject characterObj;
        float timer;
        float hp;
        float ag;
        float at;
        bool dead;
        public void Set(GameObject characterObj, float Timer, float Hp, float Ag, float At)
        {
            this.CharacterObj = characterObj;
            this.Timer = Timer;
            this.Hp = Hp;
            this.Ag = Ag;
            this.At = At;
            this.Dead = false;
        }
        public GameObject CharacterObj
        {
            set { characterObj = value; }
            get { return characterObj; }
        }
        public float Timer
        {
            set { timer = value; }
            get { return timer; }
        }
        public float Hp
        {
            set { hp = value; }
            get { return hp; }
        }
        public float Ag
        {
            set { ag = value; }
            get { return ag; }
        }
        public float At
        {
            set { at = value; }
            get { return at; }
        }
        public bool Dead
        {
            set { dead = value; }
            get { return dead; }
        }
    }

    public void SetCharacterInbattle(GameObject characterObj, float Timer, float Hp, float Ag, float At)
    {
        CharacterInbattle buffer = new CharacterInbattle();
        buffer.Set(characterObj, Timer, Hp, Ag, At);
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
