using System;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    private DiaManagerWrapper _diaManagerWrapper;
    private Dialog _dialog;

    private void Start()
    {
        _diaManagerWrapper = GetComponent<DiaManagerWrapper>();
    }
    
    /*
     * Trigger dialog on interaction
     */
    public void Interact()
    {
        if (_dialog == null) return;
        if (!gameManager.InDialog)
            gameManager.InDialog = true;
        
        _diaManagerWrapper.Interact(_dialog);
    }

    /*
     * Get dialog on collision enter
     */
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag.Contains(ConstVar.InteractObj))
        {
            _dialog = other.collider.GetComponent<Interaction>().GetDialog();
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        _dialog = null;
    }
}
