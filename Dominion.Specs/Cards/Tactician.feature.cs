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
    [NUnit.Framework.DescriptionAttribute("Tactitian")]
    public partial class TacticianFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Tactician.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tactitian", "", ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Play Tactician with a deck of 10 cards")]
        public virtual void PlayTacticianWithADeckOf10Cards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play Tactician with a deck of 10 cards", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 2 players");
#line 5
testRunner.And("Player1 has a Tactician in hand instead of a Copper");
#line 6
testRunner.When("Player1 plays a Tactician");
#line 7
testRunner.And("Player1 ends their turn");
#line 8
testRunner.And("Player2 ends their turn");
#line 9
testRunner.Then("Player1 should have 9 cards in hand");
#line 10
testRunner.And("Player1 should have 2 remaining actions");
#line 11
testRunner.And("Player1 should have 2 buys");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Play Tactician with no cards in hand")]
        public virtual void PlayTacticianWithNoCardsInHand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play Tactician with no cards in hand", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
testRunner.Given("A new game with 2 players");
#line 15
testRunner.And("Player1 has a hand of Tactician");
#line 16
testRunner.When("Player1 plays a Tactician");
#line 17
testRunner.And("Player1 ends their turn");
#line 18
testRunner.And("Player2 ends their turn");
#line 19
testRunner.Then("Player1 should have 5 cards in hand");
#line 20
testRunner.And("Player1 should have 1 remaining action");
#line 21
testRunner.And("Player1 should have 1 buy");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
