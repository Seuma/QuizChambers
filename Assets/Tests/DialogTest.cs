using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DialogTest
    {
        private Dialog _dialog;

        private bool _finished = false;
        
        [Test]
        public void Dialog_advanced_one_time()
        {
            // ACT
            CreateDialog();

            int index = 0;
            
            // ASSERT
            DiaManager.AdvanceLine(_dialog, out string outline, index, out index, out _finished);
            
            Assert.AreEqual(1, index);
            Assert.AreEqual("Lorem Ipsum", outline);
        }

        [Test]
        public void Dialog_advance_two_times()
        {
            // ACT
            CreateDialog();
            int index = 0;
            
            
            // ASSERT
            DiaManager.AdvanceLine(_dialog, out string outline, index, out index, out _finished);
            Assert.AreEqual(1, index);
            Assert.AreEqual("Lorem Ipsum", outline);
            
            DiaManager.AdvanceLine(_dialog, out outline, index, out index, out _finished);
            Assert.AreEqual(2, index);
            Assert.AreEqual("Test", outline);
        }

        private void CreateDialog()
        {
            // Create the Dialog for the test
            _dialog = ScriptableObject.CreateInstance<Dialog>();
            List<Line> lines = new List<Line>();
            string[] inLine = { "Lorem Ipsum", "Test", "Lorem Ipsum 2" };
            foreach (string s in inLine)
            {
                Line line = new Line();
                line.text = s;
                lines.Add(line);
            }

            _dialog.lines = lines.ToArray();
        }
    }
}
