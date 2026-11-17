using UnityEngine;

public class Move
{
    public MoveBase Base { get; set; }
    public int Mpcost { get; set; }

    public Move(MoveBase uBase,  int mpcost)
    {
        Base = uBase;
        Mpcost = mpcost;
    }


}
