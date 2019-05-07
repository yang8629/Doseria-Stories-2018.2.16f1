using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//紀錄戰鬥畫面中的資訊
//紀錄血量
public class BattleInfo {
    public static bool inbattle = true;
    public static List<EnemyInbattle> enemyInbattle = new List<EnemyInbattle>();//敵人資料
    public static List<CharacterInbattle> characterInbattle = new List<CharacterInbattle>();//角色資料

    public static CharacterInbattle now_character;

    public class CharacterInbattle
    {
        string name;
        GameObject characterObj;
        float timer;
        float hp;
        float ag;
        float at;
        bool moving;
        bool dead;
        public void Set(string Name, GameObject characterObj, float Hp, float Ag, float At)
        {
            this.name = Name;
            this.characterObj = characterObj;
            this.Timer = 0;
            this.Hp = Hp;
            this.ag = Ag;
            this.At = At;
            this.moving = false;
            this.dead = false;
        }
        public string Name
        {
            get { return name; }
        }
        public GameObject CharacterObj
        {
            get { return characterObj; }
        }
        public float Timer
        {
            set { timer = value; }
            get { return timer; }
        }
        public void TimerReset()
        {
            timer = 0;
        }
        public float Hp
        {
            set { hp = value; }
            get { return hp; }
        }
        public float Ag
        {
            get { return ag; }
        }
        public float At
        {
            set { at = value; }
            get { return at; }
        }
        public bool Moving
        {
            get { return moving; }
        }
        public bool Dead
        {
            get { return dead; }
        }
    }

    public static void SetCharacterInbattle(string Name, GameObject characterObj, float Hp, float Ag, float At)
    {
        CharacterInbattle buffer = new CharacterInbattle();
        buffer.Set(Name, characterObj, Hp, Ag, At);
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

    public static Vector3 camera_target_distance;
}
