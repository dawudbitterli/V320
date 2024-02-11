namespace V320_Dawud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto neuesAuto = new Auto();
            neuesAuto.starten();
        }

        class Auto
        {
            public void starten()
            {
                Motor motor = new Motor();
                motor.Pumpen();
                motor.Starten();
                Anlasser anlasser = new Anlasser();
                for (int regler = 0; regler == 7; regler++)
                {
                    motor.Regeln();
                }
                anlasser.Stoppen();
                Console.WriteLine("Auto Laeuft");
            }
        }

        class Motor
        {
            public void Pumpen()
            {
                Benzinpumpe benzinpumpe = new Benzinpumpe();
                benzinpumpe.Pumpen();
            }
            public void Regeln()
            {

            }
            public void Starten()
            {
                Console.WriteLine("Motor ist gestartet");
            }
        }

        class Benzinpumpe
        {
            public void Pumpen()
            {

            }
        }

        class Anlasser
        {
            public void Stoppen()
            {

            }
        }
    }
}