using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Test
{
    public class DiaManagerTest : MonoBehaviour
    {
        [SerializeField] private Dialog dia;
        [SerializeField] private Text text;

        private TestInput _input;
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
            AdvanceLine();
        }

        private void AdvanceLine()
        {
            if (_index < dia.lines.Length)
            {
                Clear();
                StartCoroutine(SpellLine(dia.lines[_index].text));
                _index++;
            }
            else
            {
                _index = 0;
                Clear();
            }
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
}
