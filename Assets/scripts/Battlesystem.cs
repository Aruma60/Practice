using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// Edit this for 3 player

public enum BattleState { START, PLAYERTURN, PLAYERMOVE, ENEMYTURN, WON, LOSS, BUSY }


public class Battlesystem : MonoBehaviour

{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleHUD playerHud;
    [SerializeField] BattleHUD enemyHud;
    [SerializeField] BattleDialogueBox dialogueBox;




    public BattleState state;
    int currentAction;
    int currentMove;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {


        StartCoroutine(SetupBattle());

    }

    public IEnumerator SetupBattle()
    {
        playerUnit.Setup();
        enemyUnit.Setup();
        playerHud.SetData(playerUnit.unit);
        enemyHud.SetData(enemyUnit.unit);

        dialogueBox.SetMoveNames(enemyUnit.unit.Moves);


       // Edit later to accomodate for what I actually want to accomplish from the code.

        // Edit later to accomodate for multiple players and enemies
        yield return dialogueBox.TypeDialogue($" {enemyUnit}  is ready for battle!");
        yield return new WaitForSeconds(1f);

        PlayerAction();
     }


    void PlayerAction()
    {
        state = BattleState.PLAYERTURN;
        StartCoroutine(dialogueBox.TypeDialogue("What will you do?"));
        dialogueBox.EnableActionSelector(true);
    }

    public void PlayerMove()
    {
        state = BattleState.PLAYERMOVE;
        dialogueBox.EnableActionSelector(false);
        dialogueBox.EnableDialogueText(false);
        dialogueBox.EnableMoveSelector(true);


    }

    private void Update()
    {
        if (state == BattleState.PLAYERTURN)
        {
            HandleActionSelection();
        }
        else if (state == BattleState.PLAYERMOVE)
        {
            HandleMoveSelection();
        }

    }

    void HandleActionSelection()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentAction < 2)
            {
                ++currentAction;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (currentAction > 0)
                    --currentAction;
            }
        }

        dialogueBox.UpdateActionSelection(currentAction);

        if (Input.GetKeyDown(KeyCode.Z))
            if (currentAction == 0)
            {
                //Fight
            }
            else if (currentAction == 1)
            {
                //Skills
            }
            else if (currentAction == 2)
            {
                //Run??
            }


    }

    void HandleMoveSelection()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentMove < playerUnit.unit.Moves.Count - 1)
                ++currentMove;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentMove > 0)
                --currentMove;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentMove < playerUnit.unit.Moves.Count - 2)
                currentMove += 2;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currentMove > 1)
                currentMove -= 2;
        }

        dialogueBox.UpdateMoveSelection(currentMove);
    } }
