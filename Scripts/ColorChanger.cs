using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Color _desiredColor;
    [SerializeField] private float _duration;

    private int _repats = -1;
    private LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        _camera.DOColor(_desiredColor, _duration).SetLoops(_repats, _loopType)
;    }
}