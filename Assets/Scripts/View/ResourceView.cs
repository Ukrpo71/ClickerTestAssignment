using UnityEngine;
using UnityEngine.UI;

public class ResourceView : MonoBehaviour
{
    [SerializeField] private Text _text;

    private Resource _resource;

    public void Init(Resource resource)
    {
        _resource = resource;

        UpdateText();
        
        _resource.QuantityChanged += UpdateText;
    }

    private void UpdateText()
    {
        _text.text = _resource.Value.ToString();
    }

    private void OnDestroy()
    {
        _resource.QuantityChanged -= UpdateText;
    }
}
