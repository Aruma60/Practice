using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour 
{
    [SerializeField] UnitBase _base;
    [SerializeField] int level;
    [SerializeField] bool isPlayerUnit;

    public Unit unit { get; set; }
    
    public void Setup()
    {
        unit = new Unit(_base, level);
        if (isPlayerUnit)
            GetComponent<Image>().sprite = unit.Base.BattleSprite;
    }

}
