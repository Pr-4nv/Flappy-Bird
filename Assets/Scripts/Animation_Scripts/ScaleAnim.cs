using UnityEngine;

public class ScaleAnim : MonoBehaviour
{
    #region OnEnabled Settings

    [Header("OnEnabled Settings")]
    [SerializeField] Vector3 ScaleTo;
    [SerializeField] AnimationCurve scaleCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
    [SerializeField] float AnimationTime = 1f;
    [SerializeField] float Delay = 0f;

    #endregion

    #region Animation Type

    [Header("Animation Type")]
    public LeanTweenType EaseType = LeanTweenType.easeInOutElastic;

    #endregion

    #region OnDisable Settings

    [Header("OnDisable Settings")]
    [SerializeField] bool ScaleOnDisable = false;
    [SerializeField] Vector3 DisableScaleTo;
    [SerializeField] AnimationCurve disableScaleCurve = AnimationCurve.Linear(0f, 1f, 1f, 0f);
    [SerializeField] float DisableAnimationTime = 1f;
    [SerializeField] float DisableDelay = 0f;

    #endregion

    #region Animation Type

    [Header("Animation Type")]
    [SerializeField] LeanTweenType DisableEaseType = LeanTweenType.easeInOutElastic;

    #endregion

    [Header("Loop Settings")]
    [SerializeField] bool loopEnabled = false;
    [SerializeField] int loopCount = 1;

    [Header("Curve Settings")]
    [SerializeField] bool OnEnabledCurve = true;
    [SerializeField] bool OnDisableCurve = true;

    private Vector3 zeroScale; 

    private void Start()
    {
        zeroScale = transform.localScale;
    }

    private void OnEnable()
    {
        if (OnEnabledCurve)
        {
            LeanTween.scale(gameObject, ScaleTo, AnimationTime).setDelay(Delay).setEase(EaseType).setLoopType(loopEnabled ? LeanTweenType.clamp : LeanTweenType.once)
            .setRepeat(loopCount).setOnUpdate(ScaleByCurve);
        }
        else
        {
            LeanTween.scale(gameObject, ScaleTo, AnimationTime).setDelay(Delay).setEase(EaseType).setLoopType(loopEnabled ? LeanTweenType.clamp : LeanTweenType.once)
            .setRepeat(loopCount);
        }
    }

    private void ScaleByCurve(float value)
    {
        transform.localScale = Vector3.LerpUnclamped(zeroScale, ScaleTo, scaleCurve.Evaluate(value));
    }

    private void OnDisable()
    {
        if (ScaleOnDisable)
        {
            if (OnDisableCurve)
            {
                LeanTween.scale(gameObject, DisableScaleTo, DisableAnimationTime).setDelay(DisableDelay).setEase(DisableEaseType).setOnUpdate(ScaleByDisableCurve);
            }
            else
            {
                LeanTween.scale(gameObject, DisableScaleTo, DisableAnimationTime).setDelay(DisableDelay).setEase(DisableEaseType);
            }
        }
        else
        {
            transform.localScale = zeroScale;
        }
    }

    private void ScaleByDisableCurve(float value)
    {
        transform.localScale = Vector3.LerpUnclamped(ScaleTo, DisableScaleTo, disableScaleCurve.Evaluate(value));
    }
}
