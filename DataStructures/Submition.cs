using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Submition
    {
        Dictionary<string, int>  Answers{ get; set; }

        public Submition()
        {
            Answers = new Dictionary<string, int>();
        }

        public void AddAnswer(string Alias, int Answer)
        {
            Answers.Add(Alias, Answer);
        }

        public static string GetSubmitionString(List<Submition> Submitions)
        {
            StringBuilder SubmitionString = new StringBuilder();
            foreach(Submition Submition in Submitions)
            {
                foreach (KeyValuePair<string, int> Answer in Submition.Answers)
                {
                    SubmitionString.Append(Answer.Value + ",");
                }
                SubmitionString.Remove(SubmitionString.Length - 1, 1);
                SubmitionString.Append("\n");
            }
            return SubmitionString.ToString();
        }
    }
}
