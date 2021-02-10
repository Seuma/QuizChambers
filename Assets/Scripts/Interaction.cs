using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private Dialog dia;

    public Dialog GetDialog()
    {
        return this.dia;
    }
}
