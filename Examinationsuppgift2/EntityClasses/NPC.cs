namespace Examinationsuppgift2.EntityClasses
{
    public class NPC : EntityClass
    {
        public void SetActionState(Player player)
        {
            if (player.AmmoCount == 0)
            {
                ActionState = ActionOptions.Load;
            }
            else if (player.AmmoCount >= 0)
            {
                ActionState = ChoiceRandomizer.GetRandomActionChoise();
            }
            else if (AmmoCount >= 3)
            {
                ActionState = ActionOptions.Shotgun;
            }
        }
    }
}
