using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBer : MonoBehaviour
{
    [SerializeField] private int MaxHP = 100;
    private int CurrentHP;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHP = player.HP;
    }
}
