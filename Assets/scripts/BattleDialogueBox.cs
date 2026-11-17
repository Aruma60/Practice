using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleDialogueBox : MonoBehaviour
{
    [SerializeField] Color highlightedColor;


    [SerializeField] TMP_Text dialogueText;
    [SerializeField] GameObject actionSelector;
    [SerializeField] GameObject moveSelector;
    [SerializeField] GameObject moveDetails;

    [SerializeField] List<TMP_Text> actionTexts;
    [SerializeField] List<TMP_Text> moveTexts;

    [SerializeField] TMP_Text mpTexts;
    [SerializeField] float lettersPerSecond = 30f; 



    public void SetDialogue(string dialogue)
    {
        dialogueText.text = dialogue;
    }

    public IEnumerator TypeDialogue(string dialogue)
    {
        
        foreach (var letter in dialogue.ToCharArray())
        {
            dialogueText.text +=letter;
            yield return new WaitForSeconds(1f / lettersPerSecond);
        }

    }


    public void EnableDialogueText(bool enabled)
    {
        dialogueText.enabled = enabled;

    }

    public void EnableActionSelector(bool enabled)
    {
        actionSelector.SetActive(enabled);
    }

    public void EnableMoveSelector(bool enabled)
    {
        moveSelector.SetActive(enabled);
        moveDetails.SetActive(enabled);
    }

    public void UpdateActionSelection(int selectedAction)
    {
        for (int i = 0; i < actionTexts.Count; ++i)
        {
            if (i == selectedAction)
            {
                actionTexts[i].color = highlightedColor;

            }
            else
                actionTexts[i].color = Color.black;
            //change to whatever color looks best for the menu.

        } }

        public void UpdateMoveSelection(int selectedMove)
        {
        for (int i = 0; i < moveTexts.Count; ++i)
            {
            if (i == selectedMove)
                moveTexts[i].color = highlightedColor;
            else
                moveTexts[i].color = Color.black;
            }


        }

    public void SetMoveNames(List<Move> moves)
    {
        for (int i = 0; i < moveTexts.Count; ++i)
        {
            if (i < moves.Count)
                moveTexts[i].text = moves[i].Base.name;
            else
                moveTexts[i].text = " - ";
        }

    }

}



