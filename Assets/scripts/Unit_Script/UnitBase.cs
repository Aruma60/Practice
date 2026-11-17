
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Char/Enemy", menuName = "Create Character/Enemy")]
public class UnitBase : ScriptableObject
{
    [SerializeField] string name;
    [TextArea]
    [SerializeField] string description;
    [SerializeField] Sprite battleSprite;

    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int magic;
    [SerializeField] int maxMp;
    [SerializeField] int speed;

    [SerializeField] List<LearnableMove> learnableMoves;

    public string Name => name;
    public string Description => description;
    public Sprite BattleSprite => battleSprite;
    public int MaxHp => maxHp;
    public int Attack => attack;
    public int Magic => magic;
    public int MaxMp => maxMp;
    public int Speed => speed;
    public List<LearnableMove> LearnableMoves => learnableMoves;

    [System.Serializable]
    public class LearnableMove
    {
        [SerializeField] MoveBase moveBase;
        [SerializeField] int level;

        public MoveBase Base => moveBase;
        public int Level => level;
    }
}
