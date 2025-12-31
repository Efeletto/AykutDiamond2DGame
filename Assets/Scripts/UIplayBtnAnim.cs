using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIplayBtnAnim : MonoBehaviour , 
    IPointerEnterHandler,
    IPointerExitHandler,
    IPointerDownHandler,
    IPointerUpHandler
{
    [SerializeField] private ColorBlock colorBlock;
    [SerializeField] private Animator anim;
    [SerializeField] private Button myBtn;
    private void Awake()
    {
        // Butondaki animator component'i aldýk
        anim = GetComponent<Animator>();
        myBtn = GetComponent<Button>();
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
        anim.SetBool("isPressed", false);
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
