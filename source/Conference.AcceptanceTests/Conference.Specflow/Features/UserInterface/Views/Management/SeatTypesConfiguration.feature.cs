﻿// ==============================================================================================================
// Microsoft patterns & practices
// CQRS Journey project
// ==============================================================================================================
// ©2012 Microsoft. All rights reserved. Certain content used with permission from contributors
// http://cqrsjourney.github.com/contributors/members
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance 
// with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software distributed under the License is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and limitations under the License.
// ==============================================================================================================

// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.UserInterface.Views.Management
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SeatTypesConfigurationScenariosForCreatingAndEditingSeatTypesSettingsFeature : Xunit.IUseFixture<SeatTypesConfigurationScenariosForCreatingAndEditingSeatTypesSettingsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SeatTypesConfiguration.feature"
#line hidden
        
        public SeatTypesConfigurationScenariosForCreatingAndEditingSeatTypesSettingsFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Seat Types configuration scenarios for creating and editing Seat Types settings", "In order to create or update a Seat Type\r\nAs a Business Customer\r\nI want to be ab" +
                    "le to create or update a Seat Type and set its properties", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(SeatTypesConfigurationScenariosForCreatingAndEditingSeatTypesSettingsFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Seat Types configuration scenarios for creating and editing Seat Types settings")]
        [Xunit.TraitAttribute("Description", "Seat Types are created and assigned to an existing Conference")]
        public virtual void SeatTypesAreCreatedAndAssignedToAnExistingConference()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seat Types are created and assigned to an existing Conference", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Owner",
                        "Email",
                        "Name",
                        "Description",
                        "Slug",
                        "Start",
                        "End"});
            table1.AddRow(new string[] {
                        "Gregory Weber",
                        "gregoryweber@contoso.com",
                        "CQRS2012S",
                        "CQRS summit 2012 conference (Seat Assignment)",
                        "random",
                        "05/02/2012",
                        "07/12/2012"});
#line 21
testRunner.Given("an existing unpublished conference with this information", ((string)(null)), table1);
#line 24
testRunner.And("the Business Customer selects the Seat Types opcion");
#line 25
testRunner.And("the Business Customer proceed to create new Seat Types");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "Quantity",
                        "Price"});
            table2.AddRow(new string[] {
                        "GENADM",
                        "General admission",
                        "100",
                        "199"});
#line 26
testRunner.When("the Business Customer proceed to create the Seat Types", ((string)(null)), table2);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "Quantity",
                        "Price"});
            table3.AddRow(new string[] {
                        "GENADM",
                        "General admission",
                        "100",
                        "199"});
#line 29
testRunner.Then("the new Seat Types with this information are created", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SeatTypesConfigurationScenariosForCreatingAndEditingSeatTypesSettingsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SeatTypesConfigurationScenariosForCreatingAndEditingSeatTypesSettingsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
