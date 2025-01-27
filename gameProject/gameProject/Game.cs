using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Game
    {
        public static int Ap = 10;          // attack point
        public static int Sp = 10;          // skill point
        public static int Dp = 10;          // defence point
        public static float ASpeed = 1;     // attack speed
        public static float Hp = 100;       // health point
        public static float currentHp = Hp;
        public static List<string> Abilities = new List<string>();

        public static int EnemyAp;          // attack point
        public static int EnemySp;          // skill point
        public static int EnemyDp;          // defence point
        public static float EnemyASpeed;     // attack speed
        public static float EnemyHp;       // health point
        public static string enemyType;

        public static float Xp = 0;          // experience point
        public static int Money = 0;         // money
        public static string ClassName;
        public static string Name = "";      // name, its not a point

        public static int BaseTextSpeed = 400;          // preset 400
        public static int Spl = BaseTextSpeed / 10;   // preset 40 - (speed)milisecond per letter

        public static bool yesnoOut;
        public static List<string> notAnswer = new List<string>();

        public static Random rng = new Random();
        public static MainMenu menu = new MainMenu();
        public static SaveGame save = new SaveGame();
        public static Write wr = new Write();
        public static Yesno yesno = new Yesno();
        public static Combat combat = new Combat();
        public static Shop shop = new Shop();
        public static Map map = new Map();
        public static Effects effects = new Effects();

        public static string[] lands = {"Renetria", "Vetria", "Suloqinetria", "Detenetria", "Kernil", "Xhanlir", "Vezbeflin", "Trabraquel"};
        public static int Stage = 1;
        public static bool gameStarted = false;
        public static int saveID;


        public Game()
        {

        }
    }
}
