// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.5.2
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Dominion.Specs.Cards
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Rabble")]
    public partial class RabbleFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Rabble.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Rabble", "", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Rabble is +3 cards")]
        public virtual void RabbleIs3Cards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Rabble is +3 cards", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 2 players");
#line 5
testRunner.And("Player1 has a Rabble in hand instead of a Copper");
#line 6
testRunner.When("Player1 plays a Rabble");
#line 7
testRunner.Then("Player1 should have 7 cards in hand");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player plays Rabble and the revealed cards are all treasure and actions")]
        public virtual void PlayerPlaysRabbleAndTheRevealedCardsAreAllTreasureAndActions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays Rabble and the revealed cards are all treasure and actions", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
testRunner.Given("A new game with 2 players");
#line 11
testRunner.And("Player1 has a Rabble in hand instead of a Copper");
#line 12
testRunner.And("Player2 has a deck of Copper, Militia, Copper, Estate, Estate");
#line 13
testRunner.When("Player1 plays a Rabble");
#line 14
testRunner.Then("Player2 should have 3 cards in the discard pile");
#line 15
testRunner.And("All actions should be resolved");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player plays Rabble and the revealed cards include two non-treasure non-action ca" +
            "rds")]
        public virtual void PlayerPlaysRabbleAndTheRevealedCardsIncludeTwoNon_TreasureNon_ActionCards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays Rabble and the revealed cards include two non-treasure non-action ca" +
                    "rds", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
testRunner.Given("A new game with 2 players");
#line 19
testRunner.And("Player1 has a Rabble in hand instead of a Copper");
#line 20
testRunner.And("Player2 has a deck of Estate, Curse, Copper, Copper, Estate");
#line 21
testRunner.When("Player1 plays a Rabble");
#line 22
testRunner.Then("Player2 must select a revealed card from: Estate, Curse");
#line 23
testRunner.When("Player2 selects Estate from the revealed cards");
#line 24
testRunner.Then("Player2 should have a deck of: Curse, Estate, Copper, Estate");
#line 25
testRunner.And("All actions should be resolved");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Information on Rabble effect")]
        [NUnit.Framework.CategoryAttribute("Hosted")]
        public virtual void InformationOnRabbleEffect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Information on Rabble effect", new string[] {
                        "Hosted"});
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
testRunner.Given("A new hosted game with 2 players");
#line 30
testRunner.And("Player1 has a Rabble in hand instead of a Copper");
#line 31
testRunner.And("Player2 has a deck of Estate, Curse, Copper, Copper, Estate");
#line 32
testRunner.When("The game begins");
#line 33
testRunner.And("Player1 tells the host to play Rabble");
#line 34
testRunner.Then("Player2\'s current activity should have a type of SelectFromRevealed");
#line 35
testRunner.Then("Player2\'s current activity should have a hint of RedrawCards");
#line 36
testRunner.Then("Player2\'s current activity should have a source of Rabble");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
