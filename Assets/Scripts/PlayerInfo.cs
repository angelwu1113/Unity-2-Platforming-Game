using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int health = 100;
    public int score = 0;
    public List<Collectable> inventory;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
