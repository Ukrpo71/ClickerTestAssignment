using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MultipleResourceView : MonoBehaviour
{
    [SerializeField] private Text _text;

    private List<Resource> _resources = new List<Resource>();

    public void Init(params Resource[] resources)
    {
        _resources = resources.ToList();

        UpdateText();

        foreach (var resource in resources)
        {
            resource.ResourceQuantityChanged += UpdateText;
        }
        
    }

    private void UpdateText()
    {
        int sumValue = _resources.Sum(n => n.Value);
        _text.text = sumValue.ToString();
    }

    private void OnDestroy()
    {
        foreach (var resource in _resources)
        {
            resource.ResourceQuantityChanged -= UpdateText;
        }
    }
}
