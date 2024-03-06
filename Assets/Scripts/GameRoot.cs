using UnityEngine;

public class GameRoot : MonoBehaviour
{
    private const string Gold = "Gold";
    private const string Silver = "Silver";
    private const int StartingValue = 0;

    [SerializeField] private AddResourceButton _addGoldButton;
    [SerializeField] private AddResourceButton _addSilverButton;
    [SerializeField] private ResourceView _goldView;
    [SerializeField] private ResourceView _silverView;
    [SerializeField] private MultipleResourceView _multipleResourceView;

    private void Start()
    {
        Resource gold = new Resource(StartingValue, Gold);
        Resource silver = new Resource(StartingValue, Silver);

        _addGoldButton.Init(gold);
        _addSilverButton.Init(silver);

        _goldView.Init(gold);
        _silverView.Init(silver);
        _multipleResourceView.Init(gold, silver);
    }
}
