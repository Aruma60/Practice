using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
// Edit this for 3 player

      public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOSS }
       

public class Battlesystem : MonoBehaviour

{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;


    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    Unit playerUnit;
    Unit enemyUnit;

    public TextMeshProUGUI dialogueText;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;

    public BattleState state;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 
        state = BattleState.START;
        StartCoroutine(SetupBattle());

    }

    IEnumerator SetupBattle()
    {
       GameObject playerGo =  Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGo.GetComponent<Unit>();
        
        GameObject enemyGo = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGo.GetComponent<Unit>();



        dialogueText.text = enemyUnit.unitName + " is ready for battle";

        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator PlayerAttack()
    {
        //Damage the enemy

        yield return new WaitForSeconds(1.5f);
        // Check if Enemy Dead
        //Change state based on what happens

    }

    void PlayerTurn()
    {
        dialogueText.text = "Choose an action:";

    }


    
    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerAttack());


    }

}
