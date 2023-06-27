using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    List<Character> characterList;

    void Start()
    {
        characterList = new List<Character>();

        CreateCharacter(new Character("ashe","archer",100,30));
        CreateCharacter(new Character("temo", "theif", 80, 20));
        CreateCharacter(new Character("draven", "axe",100, 30));
        
        
        CreateCharacter(new Character("ashe", "archer", 100, 30));

    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateCharacter(Character character) {
        characterList.Add(character);
    }
    void RemoveCharater(int index) {
        characterList.RemoveAt(index);
    }
    void PrintAllCharacter() {

        int i = 0;
        while(i <= characterList.Count)
        {
            characterList[i].getAtk();
            i++;
        }

    }

}
