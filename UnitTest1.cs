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
        machine.PresenceCafe = true;
        
        //when - act
        Produit monProduit = machine.userPressButton();
        
        //then - assert
        if (monProduit == null)
        {
            Assert.Fail();
        }
        
    }
}