namespace JogoRPG.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string Type, int HP, int HPFull, int MP, int MPFull){
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
            this.HP = HP;
            this.HPFull = HPFull;
            this.MP = MP;
            this.MPFull = MPFull;
        }
        public string Name;
        public int Level;
        public string Type;
        public int HP;
        public int HPFull;
        public int MP;
        public int MPFull;
        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.Type + " " + this.HP + " " + this.HPFull + " " + this.MP + " " + this.MPFull;
        }
        public virtual string Attack(){
            return this.Name + " attacked with a Bright Sword";
        }
    }
}