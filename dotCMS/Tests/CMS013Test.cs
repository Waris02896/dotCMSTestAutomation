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
    public class CMS013Test
    {
        //Verify that the Persona showing alert while publish without giving mandatory fields
        LoginSteps loginSteps = new LoginSteps();
        CMS013Steps cMS001Steps = new CMS013Steps();

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
        public void VerifyThatPersonaShowAlertWhilePublishWithoutMandatoryFields()
        {
            cMS001Steps.ClickContectButton();
            cMS001Steps.ChangeTypeToPersona();
            cMS001Steps.ClickPlusIconButton();
            cMS001Steps.publishPersona();
        }
    }
}
