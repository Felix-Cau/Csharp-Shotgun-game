namespace Examinationsuppgift2.EntityClasses
{
    public abstract class EntityClass
    {
        public int AmmoCount { get; set; } = 0;
        public ActionOptionsEnum ActionState { get; set; }
    }
}
