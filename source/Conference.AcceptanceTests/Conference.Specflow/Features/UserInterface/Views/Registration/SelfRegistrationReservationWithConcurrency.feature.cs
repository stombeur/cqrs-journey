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
namespace Conference.Specflow.Features.UserInterface.Views.Registration
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class Self_RegistrantScenariosForMakingAReservationForAConferenceSiteWhereTwoRegistrantsMakeSimultaneousReservationsFeature : Xunit.IUseFixture<Self_RegistrantScenariosForMakingAReservationForAConferenceSiteWhereTwoRegistrantsMakeSimultaneousReservationsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SelfRegistrationReservationWithConcurrency.feature"
#line hidden
        
        public Self_RegistrantScenariosForMakingAReservationForAConferenceSiteWhereTwoRegistrantsMakeSimultaneousReservationsFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Self-Registrant scenarios for making a Reservation for a Conference site where tw" +
                    "o Registrants make simultaneous reservations", "In order to reserve Seats for a Conference\r\nAs an Attendee\r\nI want to be able to " +
                    "select an Order Item from one or many of the available where other Registrants m" +
                    "ay also be interested on at the same time", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 20
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "10"});
#line 21
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table1);
#line hidden
        }
        
        public virtual void SetFixture(Self_RegistrantScenariosForMakingAReservationForAConferenceSiteWhereTwoRegistrantsMakeSimultaneousReservationsFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Self-Registrant scenarios for making a Reservation for a Conference site where tw" +
            "o Registrants make simultaneous reservations")]
        [Xunit.TraitAttribute("Description", "Only one Order Item is available and two Registrants try to reserve it, then only" +
            " one get the reservation")]
        public virtual void OnlyOneOrderItemIsAvailableAndTwoRegistrantsTryToReserveItThenOnlyOneGetTheReservation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only one Order Item is available and two Registrants try to reserve it, then only" +
                    " one get the reservation", ((string[])(null)));
#line 25
 this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "CQRS Workshop",
                        "6"});
#line 26
 testRunner.Given("the selected Order Items", ((string)(null)), table2);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table3.AddRow(new string[] {
                        "CQRS Workshop",
                        "6"});
#line 29
 testRunner.And("another Registrant selects these Order Items", ((string)(null)), table3);
#line 32
 testRunner.When("the Registrant proceed to make the Reservation");
#line 33
 testRunner.And("another Registrant proceed to make the Reservation with seats already reserved");
#line 34
 testRunner.Then("the Reservation is confirmed for all the selected Order Items");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "selected",
                        "message"});
            table4.AddRow(new string[] {
                        "CQRS Workshop",
                        "4",
                        "Could not reserve all the requested seats."});
#line 35
 testRunner.And("a second Reservation is offered to select any of these available seats", ((string)(null)), table4);
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                Self_RegistrantScenariosForMakingAReservationForAConferenceSiteWhereTwoRegistrantsMakeSimultaneousReservationsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                Self_RegistrantScenariosForMakingAReservationForAConferenceSiteWhereTwoRegistrantsMakeSimultaneousReservationsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
