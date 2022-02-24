namespace JogoRPG.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string Type, int HP, int HPFull, int MP, int MPFull) : base(Name, Level, Type, HP, HPFull, MP, MPFull)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
            this.HP = HP;
            this.HPFull = HPFull;
            this.MP = MP;
            this.MPFull = MPFull;    
        }
        public override string Attack(){
            return this.Name + " attacked with a ninja star shuriken";
        } 
    }
}