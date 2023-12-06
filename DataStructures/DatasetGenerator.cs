using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DatasetGenerator
    {
        public List<Question> Questions { get; set; }

        private Randomizer Randomizer;
        public DatasetGenerator(string WeightDataset, string LineSeperator, string ColumnSeperator)
        {
            this.Questions = new List<Question>();
            this.Randomizer = new Randomizer();

            string[] RawQuestionsWeights = WeightDataset.Split(LineSeperator);
            int QuestionAlias = 1;
            for(int i = 0; i < RawQuestionsWeights.Length; i++)
            {
                if (RawQuestionsWeights[i] == "" || RawQuestionsWeights[i] == "\t")
                {
                    continue;
                }
                Question Question = new Question(QuestionAlias.ToString(), RawQuestionsWeights[i], ColumnSeperator);
                Questions.Add(Question);
                QuestionAlias++;
            }
        }

        public List<Submition> GenerateSubmitions(int SubmitionsCount)
        {
            List<Submition> Submitions = new List<Submition>();
            for(int i = 0; i < SubmitionsCount; i++)
            {
                Submition Submition = new Submition();
                foreach(Question Question in Questions)
                {
                    Submition.AddAnswer(Question.Alias, Randomizer.GetRandomIndexWithWeight(Question.AnswerWeights));
                }
                Submitions.Add(Submition);
            }
            return Submitions;
        }

        
    }
}
