using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int health;
    public int score;
    public List<Collectable> inventory;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}