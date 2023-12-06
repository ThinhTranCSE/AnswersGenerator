namespace DataStructures
{
    public class Question
    {
        public string Alias { get; set; }
        public List<int> AnswerWeights { get; set; }

        public int TotalWeight => AnswerWeights.Sum();
        

        public Question(string Alias, string RawWeights, string Seperator)
        {
            this.Alias = Alias;
            AnswerWeights = new List<int>();
            string[] percentages = RawWeights.Split(Seperator);
            foreach (string percentage in percentages)
            {
                if (percentage == "")
                {
                    continue;
                }
                AnswerWeights.Add(int.Parse(percentage));
            }
        } 
    }
}