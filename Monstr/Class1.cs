namespace Monstr
{
    public class Stats
    {
        double Current_HP;
        double Max_HP;
        double Mass;
        double Damage;
        double DamageVer;
        double cost;
        double Dobytoe;
        double summ;
        Random rand = new Random();

        public double max_HP
        {
            get { return Max_HP; }
            set { Max_HP = value; }
        }
        public double mass
        {
            get { return Mass; }
            set { Mass = value; }
        }
        public double damage
        {
            get { return Damage; }
            set { Damage = value; }
        }
        public double damageVer
        {
            get { return DamageVer; }
            set { DamageVer = value; }
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }


        public double Current_hp()
        {
            Current_HP = Max_HP;
            int shanc = rand.Next(0, 100);
            if (shanc >= DamageVer) 
            { 
                if (Current_HP == Max_HP)
                {
                    Current_HP = Max_HP - Damage;
                }
                Current_HP = Current_HP - Damage;
                if (Current_HP <= 0)
                {
                    Current_HP = 0;
                }
            }
            return Current_HP;
        }
        public double Sell()
        {
            Dobytoe = 0;
            return summ = Dobytoe * cost;
        }
        public double Srez()
        {
            int srezan;
            double Omass;
            srezan = rand.Next(1 , 10);
            Omass = mass;
            mass = mass * (1 - (srezan / 100)) ;
            Dobytoe += Omass - mass;
            return Dobytoe;
        }
    }
}