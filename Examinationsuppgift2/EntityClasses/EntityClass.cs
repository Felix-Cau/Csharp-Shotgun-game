namespace Examinationsuppgift2.EntityClasses
{
    public abstract class EntityClass
    {
        public int AmmoCount { get; set; } = 0;
        public UserAction ActionState { get; set; }

        //public abstract void SetActionState(UserAction action);
        //public abstract void SetActionState(UserAction action, EntityClass entity);
    }
}
