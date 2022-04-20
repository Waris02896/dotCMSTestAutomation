using dotCMS.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dotCMS.Tests
{
    public class CMS001Test
    {
        //Verify that the new Persona added Successfully
        LoginSteps loginSteps = new LoginSteps();
        CMS001Steps cMS001Steps = new CMS001Steps();

        [SetUp]
        public void SetupTest()
        {
            BaseFunctions.Start();
            loginSteps.LoginStep();
            Thread.Sleep(4000);
        }

        [TearDown]
        public void TearDownTest()
        {
            BaseFunctions.End();
        }

        [Test]
        public void VerifyThePersonaAddedSuccessfully()
        {
            cMS001Steps.ClickContectButton();
            cMS001Steps.ChangeTypeToPersona();
            cMS001Steps.ClickPlusIconButton();
            cMS001Steps.FillForm();
            cMS001Steps.SavePersona();
            cMS001Steps.publishPersona();
        }
    }
}
