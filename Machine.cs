namespace testFirst_gherkin_cshrp;

public class Machine
{
    
    /*  public string Type    // the Name property
    {
        get => _type;
        set => _type = value;
    }*/
    private bool presenceMonnaie;

    public bool PresenceMonnaie
    {
        get => presenceMonnaie;
        set => presenceMonnaie = value;
    }
    private bool presencecafe;
    
    public bool PresenceCafe
    {
        get => presencecafe;
        set => presencecafe = value;
    }

    private bool buttonIspressed;

    public Machine()
    {
        
    }

    private Produit _produit;

    public Produit userPressButton()
    {
        
        if (presencecafe == true)
        {
            if (presenceMonnaie == true)
            {
               return _produit = new Produit("café");    
            }
                
        }
        else if(presencecafe == false)
        {
            return delivrerEau();
        }

        return null;

    }

    public Produit delivrerEau()
    {
        Produit flotte = new Produit("eau");
        return flotte;
    }

}