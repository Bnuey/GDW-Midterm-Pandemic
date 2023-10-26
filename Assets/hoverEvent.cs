using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class hoverEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject text;
    public void OnPointerEnter(PointerEventData eventData)
    {
        text.transform.DOScale(.5f, 0.2f).SetEase(Ease.OutQuad);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.transform.DOScale(0, 0.2f).SetEase(Ease.OutQuad);
    }
}
