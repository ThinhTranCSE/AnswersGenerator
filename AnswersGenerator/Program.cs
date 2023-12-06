using DataStructures;

namespace AnswersGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string WeightDataset = "5\t25\t15\t10\t5\t\t\t\t\t\r\n15\t10\t20\t5\t10\t0\t0\t\t\t\r\n5\t37\t15\t3\t\t\t\t\t\t\r\n2\t23\t35\t0\t0\t\t\t\t\t\r\n20\t30\t10\t0\t0\t\t\t\t\t\r\n13\t40\t7\t0\t0\t\t\t\t\t\r\n3\t7\t50\t0\t0\t\t\t\t\t\r\n10\t15\t6\t3\t7\t2\t7\t10\t0\t\r\n20\t15\t10\t10\t5\t0\t\t\t\t\r\n5\t10\t10\t5\t25\t5\t\t\t\t\r\n5\t15\t30\t7\t3\t\t\t\t\t\r\n10\t5\t15\t10\t0\t15\t5\t\t\t\r\n9\t15\t11\t12\t13\t\t\t\t\t\r\n7\t13\t17\t15\t8\t0\t\t\t\t\r\n0\t0\t0\t0\t0\t2\t15\t20\t13\t10\r\n0\t0\t0\t0\t0\t7\t25\t18\t5\t5\r\n0\t0\t0\t0\t5\t7\t14\t28\t4\t2\r\n0\t0\t0\t0\t0\t0\t38\t15\t5\t2\r\n0\t0\t0\t0\t0\t0\t9\t36\t11\t4\r\n0\t0\t0\t0\t0\t0\t7\t24\t19\t10\r\n58\t2\t\t\t\t\t\t\t\t\r\n17\t10\t8\t5\t20\t\t\t\t\t\r\n10\t20\t30\t\t\t\t\t\t\t\r\n11\t9\t14\t5\t3\t15\t0\t3\t\t\r\n13\t20\t8\t11\t5\t3\t\t\t\t\r\n8\t9\t5\t7\t13\t15\t2\t1\t\t\r\n6\t9\t4\t3\t8\t6\t24\t0\t0\t0\r\n5\t15\t10\t0\t30\t\t\t\t\t\r\n40\t15\t5\t\t\t\t\t\t\t\r\n50\t10\t\t\t\t\t\t\t\t\r\n40\t20\t\t\t\t\t\t\t\t\r\n60\t0\t\t\t\t\t\t\t\t\r\n50\t10\t0";
            string LineSeperator = "\r\n";
            string ColumnSeperator = "\t";
            int SubmitionsCount = 1000;

            DatasetGenerator DatasetGenerator = new DatasetGenerator(WeightDataset, LineSeperator, ColumnSeperator);
            var Submitions = DatasetGenerator.GenerateSubmitions(SubmitionsCount);

            Console.WriteLine(Submition.GetSubmitionString(Submitions));                       
        }
    }
}