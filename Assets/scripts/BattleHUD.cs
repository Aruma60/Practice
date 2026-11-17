using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] HPBar hpBar;
    [SerializeField] MPBar mpBar;

    //DW about mpbar script yet

    public void SetData(Unit unit)
    {
        nameText.text = unit.Base.Name;
        levelText.text = "Lvl" + unit.Level;
        hpBar.SetHP((float)unit.HP / unit.MaxHp);
    }
}
