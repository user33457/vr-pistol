using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class RukojatkaSocket : MonoBehaviour
{
    [SerializeField] private XRSocketInteractor SocketMagazineInteractor;
    private Weapons weapon;
    private void Avake() 
    {
        weapon = GetComponent<Weapons>();
        SocketMagazineInteractor.selectEntered.AddListener(OnMagazineInserted);
        SocketMagazineInteractor.selectExited.AddListener(OnMagazineExited);
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnEnable()
    {
        
    }
    private void OnMagazineInserted(SelectEnterEventArgs args) 
    {
        weapon.Reloading();
        Debug.Log("MagazineInserted");
    }
    private void OnMagazineExited(SelectExitEventArgs args)
    {
        weapon.ExetedMagazine();
        Debug.Log("MagazineExited");
    }
}
