using Examinationsuppgift2.HelperClasses;

namespace Examinationsuppgift2.EntityClasses
{
    public class NPCClass : EntityClass
    {
        public void SetActionState(EntityClass entity)
        {
            if (entity.AmmoCount == 0)
            {
                ActionState = UserAction.Load;
            }
            else if (entity.AmmoCount >= 0)
            {
                ActionState = ActionEnum.GetRandomActionChoise();
            }
            else if (AmmoCount >= 3)
            {
                ActionState = UserAction.Shotgun;
            }
        }
    }
}
