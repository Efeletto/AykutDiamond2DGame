using UnityEngine;
using UnityEngine.EventSystems;

public class UIplayBtnAnim : MonoBehaviour , 
    IPointerEnterHandler,
    IPointerExitHandler,
    IPointerDownHandler,
    IPointerUpHandler
{

    Animator anim;
    private void Awake()
    {
        // Butondaki animator component'i aldýk
        anim = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        anim.Rebind();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Pointer button'un üzerine geldi
        anim.SetBool("isHover",true);
    }
    public void OnPointerExit(PointerEventData eventData) {
        //Pointer button'un üzerinden gitti
        anim.SetBool("isHover",false);
    }

    public void OnPointerUp(PointerEventData eventData) {
        //Butona basma islemi bitt
        anim.SetBool("isPressed",false);

    }

    public void OnPointerDown(PointerEventData eventData) {
        //Butona basýldý 
        anim.SetBool("isPressed", true);
    }

}
