namespace Examinationsuppgift2.EntityClasses
{
    public class Npc : EntityClass
    {
        public void SetActionState(Player player)
        {
            if (player.AmmoCount == 0)
            {
                ActionState = ActionOptionsEnum.Load;
            }
            else if (player.AmmoCount >= 0)
            {
                ActionState = ChoiceRandomizer.GetRandomActionChoise();
            }
            else if (AmmoCount == 0)
            {
                ActionState = ChoiceRandomizer.GetRandomActionChoise(ActionOptionsEnum.Load, ActionOptionsEnum.Block);
            }
            else if (AmmoCount >= 3)
            {
                ActionState = ActionOptionsEnum.Shotgun;
            }
        }
    }
}
