namespace PR32_ObserverPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initiating Academies
            Academy UCL = new Academy("UCL", "Seebladsgade");
            Academy EASV = new Academy("EASV", "Alsion 3");
            // Initiating Students
            Student s1 = new Student(UCL, "Jens");
            Student s2 = new Student(UCL, "Niels");
            Student s3 = new Student(UCL, "Susan");
            Student s4 = new Student(EASV, "Jeppe");
            Student s5 = new Student(EASV, "Niclas");
            // Attaching
            UCL.Attach(s1);
            UCL.Attach(s2);
            UCL.Attach(s3);
            EASV.Attach(s4);
            EASV.Attach(s5);
            // Setting messages and detaching a student
            UCL.Message = "Så er der julefrokost!";

            UCL.Detach(s2);

            EASV.Message = "Mooooojn";

            EASV.Message = UCL.Message;
            UCL.Message = "Så er der fredagsbar!";

        }
    }
}
