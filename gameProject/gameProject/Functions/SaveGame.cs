using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class SaveGame: Game
    {
        public SaveGame()
        {

        }

        public void save()
        {
            using (StreamWriter saveWrite = new StreamWriter("save.txt"))
            {
                saveWrite.WriteLine(Ap);
                saveWrite.WriteLine(Sp);
                saveWrite.WriteLine(Dp);
                saveWrite.WriteLine(currentHp);
                saveWrite.WriteLine(ASpeed);
                saveWrite.WriteLine(Hp);
                saveWrite.WriteLine(Name);
                saveWrite.WriteLine(ClassName);
                saveWrite.WriteLine(EnemyAp);
                saveWrite.WriteLine(EnemySp);
                saveWrite.WriteLine(EnemyDp);
                saveWrite.WriteLine(EnemyASpeed);
                saveWrite.WriteLine(EnemyHp);
                saveWrite.WriteLine(Money);
                saveWrite.WriteLine(BaseTextSpeed);
                saveWrite.WriteLine(gameStarted);
                saveWrite.WriteLine(Stage);
                saveWrite.Close();
            }
        }

        public void load()
        {
            string checkifgamestarted;
            using (StreamReader saveRead = new StreamReader("save.txt"))
            {
                Ap = Convert.ToInt16(saveRead.ReadLine());
                Sp = Convert.ToInt16(saveRead.ReadLine());
                Dp = Convert.ToInt16(saveRead.ReadLine());
                currentHp = (float)Convert.ToDouble(saveRead.ReadLine());
                ASpeed = (float)Convert.ToDouble(saveRead.ReadLine());
                Hp = (float)Convert.ToDouble(saveRead.ReadLine());
                Name = saveRead.ReadLine();
                ClassName = saveRead.ReadLine();
                EnemyAp = Convert.ToInt16(saveRead.ReadLine());
                EnemySp = Convert.ToInt16(saveRead.ReadLine());
                EnemyDp = Convert.ToInt16(saveRead.ReadLine());
                EnemyASpeed = (float)Convert.ToDouble(saveRead.ReadLine());
                EnemyHp = (float)Convert.ToDouble(saveRead.ReadLine());
                Money = Convert.ToInt16(saveRead.ReadLine());
                BaseTextSpeed = Convert.ToInt16(saveRead.ReadLine());
                checkifgamestarted = saveRead.ReadLine();
                Stage = Convert.ToInt16(saveRead.ReadLine());
            }
            if (checkifgamestarted == "True") { gameStarted = true; }
            else { gameStarted = false; }

            Detenetria detenetria = new Detenetria();
            Vetria vetria = new Vetria();
            Renetria renetria = new Renetria();
            Kernil kernil = new Kernil();
            switch (Stage)
            {
                case 1:
                    CharacterCreation chcreate = new CharacterCreation();
                    chcreate.start();
                    break;
                case 2:
                    map.input();
                    break;
                case 3:
                    detenetria.start();
                    break;
                case 31:
                    detenetria.tale3();
                    break;
                case 32:
                    detenetria.tale41();
                    break;
                case 4:
                    vetria.start();
                    break;
                case 41:
                    vetria.tale2();
                    break;
                case 5:
                    renetria.start();
                    break;
                case 51:
                    renetria.tale6();
                    break;
                case 6:
                    kernil.start();
                    break;

            }
        }
    }
}
