using System;

namespace testFirst_gherkin_cshrp;

public class Produit
{
    public Produit(string type)
    {
        _type = type;
    }

    private string _type;

    public string Type    // the Name property
    {
        get => _type;
        set => _type = value;
    }
}