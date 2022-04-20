using dotCMS.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotCMS.Steps
{
    public class CMS013Steps
    {
        //Verify that the Persona showing alert while publish without giving mandatory fields
        CMS013Actions action = new CMS013Actions();

        public void ClickContectButton()
        {
            action.OpenMenu();
            action.ContentForm();
        }

        public void ChangeTypeToPersona()
        {
            action.InputInPersonaFilter();
        }

        public void ClickPlusIconButton()
        {
            action.ClickPlusButton();
            action.OpenNewPersonaForm();
        }

        public void publishPersona()
        {
            action.publish();
        }
    }
}
