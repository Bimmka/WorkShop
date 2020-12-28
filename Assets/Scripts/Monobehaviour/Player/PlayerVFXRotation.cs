#pragma warning disable 0649
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PlayerVFXRotation : MonoBehaviour, IVfxRotate
{
    [Header("SpriteRendered для VFX")]
    [SerializeField] private SpriteRenderer vfxSpriteRenderer;

    private Vector3 rotateForForwardView = new Vector3(0, 0, 90);
    private Vector3 rotateForLeftView = new Vector3(0, 0, 0);

    private void SetRotateForForwardView(bool isForward)
    {
        vfxSpriteRenderer.flipY = isForward;
        transform.localEulerAngles = rotateForForwardView;
    }

    private void SetRotateForLeftView(bool isLeft)
    {
        vfxSpriteRenderer.flipY = isLeft;
        transform.localEulerAngles = rotateForLeftView;
    }

    public void SetRotateByView(string view)
    {
        switch (view)
        {
            case "Forward":
                SetRotateForForwardView(true);
                break;
            case "Behind":
                SetRotateForForwardView(false); 
                break;
            case "Right": 
                SetRotateForLeftView(false);
                break;
            case "Left":
                SetRotateForLeftView(true);
                break;
        }
    }




}
