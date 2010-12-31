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
    [NUnit.Framework.DescriptionAttribute("University")]
    public partial class UniversityFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "University.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "University", "", ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Player plays University and must select an action card to gain")]
        public virtual void PlayerPlaysUniversityAndMustSelectAnActionCardToGain()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays University and must select an action card to gain", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 3 players");
#line 5
testRunner.And("Player1 has a University in hand instead of a Copper");
#line 6
testRunner.When("Player1 plays a University");
#line 7
testRunner.Then("Player1 may gain an action card of cost 5 or less");
#line 8
testRunner.And("Player1 should have 2 remaining actions");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player plays University and selects an action")]
        public virtual void PlayerPlaysUniversityAndSelectsAnAction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays University and selects an action", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
testRunner.Given("A new game with 3 players");
#line 12
testRunner.And("Player1 has a University in hand instead of a Copper");
#line 13
testRunner.When("Player1 plays a University");
#line 14
testRunner.And("Player1 gains a Moat");
#line 15
testRunner.Then("All actions should be resolved");
#line 16
testRunner.Then("Player1 should have a Moat on top of the discard pile");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player plays University and chooses not to gain")]
        public virtual void PlayerPlaysUniversityAndChoosesNotToGain()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays University and chooses not to gain", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
testRunner.Given("A new game with 3 players");
#line 20
testRunner.And("Player1 has a University in hand instead of a Copper");
#line 21
testRunner.When("Player1 plays a University");
#line 22
testRunner.And("Player1 gains nothing");
#line 23
testRunner.Then("All actions should be resolved");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion