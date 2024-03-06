using System;
using UnityEngine;
using UnityEngine.UI;

public class AddResourceButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Text _buttonText;

    private Resource _resource;

    private const string Add = "Add";

    public void Init(Resource resource)
    {
        _resource = resource;

        _buttonText.text = Add + " " + resource.Name;
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(IncreaseResource);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(IncreaseResource);
    }

    private void IncreaseResource()
    {
        if (_resource == null)
            throw new NullReferenceException();

        _resource.IncreaseResource();
    }
}
