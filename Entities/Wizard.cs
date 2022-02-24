namespace JogoRPG.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string Type, int HP, int HPFull, int MP, int MPFull) : base(Name, Level, Type, HP, HPFull, MP, MPFull)
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
            return this.Name + " attacked with magic";
        } 
        public string Attack(int Damage){
            if(Damage > 200){
            return this.Name + " attacked with an extra magic damage " + Damage;   
            }
            else{
            return this.Name + " attacked with a week magic damage  " + Damage;
            }
        }
    }
}