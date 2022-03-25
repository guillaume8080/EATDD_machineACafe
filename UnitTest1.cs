using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testFirst_gherkin_cshrp;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void livrerCafeSimple()
    {
        //given - arrange
        Machine machine = new Machine();
        machine.PresenceMonnaie = true;
        machine.PresenceCafe = true;
        
        //when - act
        Produit monProduit = machine.userPressButton();
        
        //then - assert
        if (monProduit == null)
        {
            Assert.Fail();
        }
        
    }
    
    [TestMethod]
    public void LivreEau()
    {
        //given - arrange
        Machine machine = new Machine();
        machine.PresenceMonnaie = true;
        machine.PresenceCafe = false;
        
        //when - act
        Produit monProduit = machine.userPressButton();
        
        //then - assert
        if (monProduit == null)
        {
            Assert.Fail();
        }

        if (monProduit.TypeBoisson != "eau")
        {
            Assert.Fail();
        }
        
    }
    
    [TestMethod]
    public void LivrerSucreAvecBoisson()
    {
        //given - arrange
        Machine machine = new Machine();
        machine.PresenceMonnaie = true;
        machine.PresenceCafe = true;
        machine.DesireSucre = true;

        //when - act
        Produit monProduit = machine.userPressButton();
        
        //then - assert
        // checker 2 cas si il y a du sucre dans le produit ou pas (booleen)
        if (!monProduit.DesireSucre)
        {
            Assert.Fail();
        }
        

    }
    
    [DataTestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public void volumeSucreBoisson(int volumeSucreUtilisateur)
    {
        //given - arrange
        Machine machine = new Machine();
        machine.PresenceMonnaie = true;
        machine.PresenceCafe = true;
        machine.DesireSucre = true;
        machine.VolumeSucreUser = volumeSucreUtilisateur;

        //when - act
        Produit monProduit = machine.userPressButton();
        
        //then - assert
        // checker 2 cas si il y a du sucre dans le produit ou pas (booleen)
        if (monProduit.VolumeSucre != machine.VolumeSucreUser)
        {
            Assert.Fail();
        }
        

    }
    [TestMethod]
    public void gobeletUtilisateur()
    {
        //given - arrange
        Machine machine = new Machine();
        machine.PresenceMonnaie = true;
        machine.PresenceCafe = true;
        //machine.DesireSucre = true;
        //machine.VolumeSucreUser = 3;
        machine.PresenceGobelet = true;

        //when - act
        Produit monProduit = machine.userPressButton();
        
        //then - assert
        // checker 2 cas si il y a du sucre dans le produit ou pas (booleen)
        if (!monProduit.TypeGobeletUtilisateur)
        {
            Assert.Fail();
        }
        

    }
   
}
