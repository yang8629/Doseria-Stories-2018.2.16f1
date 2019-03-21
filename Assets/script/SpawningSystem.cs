using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningSystem : MonoBehaviour {
    public CharacterData[] all_character;

    void Awake(){
        for (int i = 0; i < all_character.Length; i++)
        {
            BattleInfo.SetCharacterInbattle(all_character[i].name, all_character[i].characterObj, all_character[i].Hp, all_character[i].Ag, all_character[i].At);
        }
	}
}
