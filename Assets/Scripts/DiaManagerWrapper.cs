using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DiaManagerWrapper: MonoBehaviour
{
    // [SerializeField] private Dialog dia;
    [SerializeField] private GameObject panel;
    [SerializeField] private Text text;
    [SerializeField] private GameManager gameManager;
    
    private string _line;
    private int _index;

    private bool _finished;
    
    /*
     * trigger functions on interaction
     */
    public void Interact(Dialog dia)
    {
        Clear();
        if (!_finished)
        {
            if (!panel.activeSelf)
                panel.SetActive(true);
            DiaManager.AdvanceLine(dia, out _line, _index, out _index, out _finished);
            StartCoroutine(SpellLine(_line));
        }
        
        if (_finished)
        {
            panel.SetActive(false);
            _finished = false;
            gameManager.InDialog = false;
        }
    }
    
    /*
     * Stop all coroutines to prevent new text
     * Clear the text
     */
    private void Clear()
    {
        StopAllCoroutines();
        text.text = "";
    }
    
    /*
     * Show the text character by character
     */
    private IEnumerator SpellLine(string line)
    {
        foreach (char s in line)
        {
            text.text += s;
            yield return new WaitForSeconds(0.01f);
        }
    }
}

public static class DiaManager
{
    /*
     * Advance the line of the dialog
     * - get the current line of the dialog
     * - increase the current index
     * - on last index reset index and line
     */
    public static void AdvanceLine(Dialog dia, out string line, int oldIndex, out int index, out bool finished)
    {
        index = oldIndex;
        if (index < dia.lines.Length)
        {
            line = dia.lines[index].text;
            index++;
            finished = false;
        }
        else
        {
            line = "";
            index = 0;
            finished = true;
        }
    }
}