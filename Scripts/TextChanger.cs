using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _fadeDuration;
    [SerializeField] private float changeColorDuration;
    [SerializeField] private float _delay;
    [SerializeField] private float _changeTextDuration;
    [SerializeField] private Color _color;

    private Sequence _sequence;

    private void Start()
    {
        _sequence = DOTween.Sequence();

        _sequence.Append(_text.DOFade(1, _fadeDuration));
           _sequence.Insert(_delay, _text.DOText("НО ЕЕ ЗДЕСЬ НЕТ", _changeTextDuration).SetRecyclable());
        _sequence.Insert(_delay, _text.DOColor(_color, changeColorDuration));
    }
}
