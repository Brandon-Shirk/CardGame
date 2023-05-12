using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class CardGenerator_Generic : MonoBehaviour
{
    public CardData_Creature creatureData;
    public bool useCardArt = true;

    [Header("Title Bar")]
    public TextMeshProUGUI cardName;
    public TextMeshProUGUI manaCost;
    public RawImage art;
    public TextMeshProUGUI archetypeText;
    public GameObject statsRoot;

    [Header("Effect1")]
    public GameObject effectRoot1;
    public TextMeshProUGUI effectType1;
    public TextMeshProUGUI effectReq1;
    public TextMeshProUGUI effectCost1;
    public TextMeshProUGUI effectText1;

    [Header("Effect2")]
    public GameObject effectRoot2;
    public TextMeshProUGUI effectType2;
    public TextMeshProUGUI effectReq2;
    public TextMeshProUGUI effectCost2;
    public TextMeshProUGUI effectText2;

    [Header("Stats")]
    public TextMeshProUGUI movement;
    public TextMeshProUGUI strength;
    public TextMeshProUGUI defense;
    public TextMeshProUGUI range;
    public TextMeshProUGUI rangedStrength;

    // Start is called before the first frame update
    void Start()
    {
        string s;

        s = (creatureData.cardName != null) ? creatureData.cardName : "";
        cardName.text = s;

        s = (creatureData.manaCost != null) ? creatureData.manaCost : "";
        manaCost.text = s;

        s = (creatureData.superType != SuperType.none) ? creatureData.superType.ToString() : "";
        if (creatureData.subType != SubType.none)
        {
            s += " - " + creatureData.subType.ToString();
        }
        archetypeText.text = s;




        // EFFECT 1
        if (creatureData.effects.Length >= 1)
        {
            s = creatureData.effects[0].effectType.ToString();
            effectType1.text = s;
            s = (creatureData.effects[0].effectRequirements != null)? creatureData.effects[0].effectRequirements : "";
            effectReq1.text = s;
            s = (creatureData.effects[0].effectManaCost != null) ? creatureData.effects[0].effectManaCost : "";
            effectCost1.text = s;
            s = (creatureData.effects[0].effectText != null) ? creatureData.effects[0].effectText : "";
            effectText1.text = s;
        }
        else
        {
            effectRoot1.SetActive(false);
            effectRoot2.SetActive(false);
            //effectType1.text = "";
            //effectReq1.text = "";
            //effectText1.text = "";
            //effectCost1.text = "";
        }


        // EFFECT 2
        if (creatureData.effects.Length >= 2)
        {
            s = creatureData.effects[1].effectType.ToString();
            effectType2.text = s;
            s = (creatureData.effects[1].effectRequirements != null) ? creatureData.effects[1].effectRequirements : "";
            effectReq2.text = s;
            s = (creatureData.effects[1].effectManaCost != null) ? creatureData.effects[1].effectManaCost : "";
            effectCost2.text = s;
            s = (creatureData.effects[1].effectText != null) ? creatureData.effects[1].effectText : "";
            effectText2.text = s;
        }
        else
        {
            effectRoot2.SetActive(false);
        }








        // STATS
        s = (creatureData.movement != null) ? "M:" + creatureData.movement: "";
        movement.text = s;
        s = (creatureData.strength != null) ? "S:" + creatureData.strength: "";
        strength.text = s;
        s = (creatureData.defense != null) ? "D:" + creatureData.defense: "";
        defense.text = s;
        s = (creatureData.rangedDistance != null) ? "R:" + creatureData.rangedDistance: "";
        range.text = s;
        s = (creatureData.rangedStrength != null) ? "B:" + creatureData.rangedStrength : "";
        rangedStrength.text = s;




        // ART
        if (useCardArt && creatureData.art != null)
        {
            art.enabled = true;
            art.texture = creatureData.art;
        }
        else
        {
            art.enabled = false;
        }

        if (creatureData.cardType != CardType.creature)
        {
            statsRoot.SetActive(false);
        }
    }
}
