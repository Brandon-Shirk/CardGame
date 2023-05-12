using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "CreatureData", menuName = "ScriptableObjects/CardData Creature", order = 1)]
public class CardData_Creature : ScriptableObject
{
    public CardType cardType;
    //public SuperType cardType;
    public string cardName;
    public ManaType manaType;
    public string manaCost;
    public Texture2D art;

    public SuperType superType;
    public SubType subType;


    [Header("Stats")]
    public string movement;
    public string strength;
    public string defense;
    public string rangedDistance;
    public string rangedStrength;


    [Header("Effects")]
    public CardEFfect[] effects;
}



public enum ManaType
{
    earth,
    wind,
    fire,
    leaf,
    water,
    spirit
}

public enum SuperType
{
    none,
    human,
    beast, // Creature? Fauna?
    spirit,

}

public enum SubType
{
    none,
    soldier,
    sea, // ?? Should this be a super-type?
    jungle
}

public enum EffectType
{
    ignition,
    trigger,
    passive
}

[Serializable]
public class CardEFfect
{
    public EffectType effectType;
    public bool isInstant;
    public string effectManaCost;
    public string effectRequirements;
    public string effectText;
}

public enum CardType
{
    creature,
    support
}