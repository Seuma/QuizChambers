using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DiaManagerWrapper: MonoBehaviour
{
    [SerializeField] private Dialog dia;
    [SerializeField] private Text text;

    private TestInput _input;
    private string _line;
    private int _index;
    
    private void Start()
    {
        _input = new TestInput();
        _input.Enable();
    }

    private void Update()
    {
        if (_input.Test.Int.triggered)
        {
            Interact();
        }
    }

    private void Interact()
    {
        Clear();
        DiaManager.AdvanceLine(dia, out _line, _index, out _index);
        StartCoroutine(SpellLine(_line));
    }

    private void Clear()
    {
        StopAllCoroutines();
        text.text = "";
    }

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
    public static void AdvanceLine(Dialog dia, out string line, int oldIndex, out int index)
    {
        index = oldIndex;
        if (index < dia.lines.Length)
        {
            line = dia.lines[index].text;
            index++;
        }
        else
        {
            line = "";
            index = 0;
        }
    }
}