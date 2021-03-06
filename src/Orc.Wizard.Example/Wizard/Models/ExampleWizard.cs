﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExampleWizard.cs" company="WildGums">
//   Copyright (c) 2008 - 2015 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Wizard.Example.Wizard
{
    using System.Threading.Tasks;
    using Catel.IoC;
    using Catel.Logging;

    public class ExampleWizard : WizardBase
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        public ExampleWizard(ITypeFactory typeFactory)
            : base(typeFactory)
        {
            Title = "Orc.Wizard example"; 

            this.AddPage<PersonWizardPage>();
            this.AddPage<AgeWizardPage>();
            this.AddPage<SkillsWizardPage>();
            this.AddPage<ComponentsWizardPage>();
            this.AddPage<SummaryWizardPage>();

            // Test for numbers being updated correctly
            this.InsertPage<GadgetsWizardPage>(3);

            MinSize = new System.Windows.Size(800, 600);
            MaxSize = new System.Windows.Size(1000, 800);
            ResizeMode = System.Windows.ResizeMode.CanResize;
        }

        public bool ShowInTaskbarWrapper
        {
            get {  return ShowInTaskbar; }
            set { ShowInTaskbar = value; }
        }

        public bool HandleNavigationStatesWrapper
        {
            get {  return HandleNavigationStates; }
            set { HandleNavigationStates = value; }
        }

        public override async Task ResumeAsync()
        {
            Log.Info("Resuming wizard");

            await base.ResumeAsync();
        }

        public override async Task SaveAsync()
        {
            Log.Info("Saving wizard");

            await base.SaveAsync();
        }
    }
}
