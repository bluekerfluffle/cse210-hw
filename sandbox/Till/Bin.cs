class Bin
{
    //attributes
    private string _denominations;
    private int _amount;
    private float _value;

    //methods
    public void ModifyAmount(int amount)
    {
        _amount += amount;

    }

    public float TotalValue()
    {
        return _amount * _value;
    }

    //constructors
    public Bin(string _denominations, int amount, float _value)
    {
        _denominations = denomination;
        _amount = amount;
        _value = value;
    }
}