using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameSpace : MonoBehaviour
{
    [SerializeField] private GameObject text;

    public void Enter()
    {
        Debug.Log("Enter");
        text.transform.DOScale(1, 1);
        text.transform.DOMoveY(text.transform.position.y + 1, 1);


    }

    public void Exit()
    {
        text.transform.DOScale(0, 1);
        text.transform.DOMoveY(text.transform.position.y - 1, 1);
    }
}
