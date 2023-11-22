using System.Reflection.Metadata.Ecma335;
namespace RetezecUtil
{
    public class Class1
    {
        public bool ObsahujeSlovo(string text)
        {
            string[] pole = text.Split(' ');
            if (pole.Length > 0)
            {
                return true;
            }
            return false;
        }
        public string nejdelsinejmensi(string text)
        {
            string nejkratsi = "";
            int delkanejkratsiho = int.MaxValue;

            string nejdelsi = "";
            int delkanejdelsiho = int.MinValue;

            string[] pole = text.Split(' ');
            foreach (string p in pole)
            {
                int delka = p.Length;
                if (delka > delkanejdelsiho)
                {
                    nejdelsi = p;
                    delkanejdelsiho = delka;
                }
                if (delka < delkanejkratsiho)
                {
                    nejkratsi = p;
                    delkanejkratsiho = delka;
                }
            }
            return "Nejdelsi slovo je: " + nejdelsi + "\nNejkratsi slovo je: " + nejkratsi;
        }
    }
}