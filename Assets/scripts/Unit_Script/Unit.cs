
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
   public UnitBase Base { get; set; }
   public int Level { get; set; }
    public int Mp { get; set; }
    public int HP { get; set; }

    public List<Move> Moves { get; set; }

    public Unit(UnitBase uBase, int uLevel)
    {
        Base = uBase;
        Level = uLevel;

        HP = MaxHp;

        // Generate Moves
        Moves = new List<Move>();

        foreach (var move in Base.LearnableMoves)
        {
            if (move.Level <= Level)
            {
                Moves.Add(new Move(move.Base, move.Base.Mpcost));
            }

            if (Moves.Count >= 4)
                break;
        }
    }

    public int Attack
    {
        get { return Mathf.FloorToInt((Base.Attack * Level) / 100f) + 5; }
    }

    public int Magic
    {
        get { return Mathf.FloorToInt((Base.Magic * Level) / 100f) + 5; }
    }

    public int Speed
    {
        get { return Mathf.FloorToInt((Base.Speed * Level) / 100f) + 5; }
    }

    public int MaxHp
    {
        get { return Mathf.FloorToInt((Base.MaxHp * Level) / 100f) + 10; }
    }

  

    
}
