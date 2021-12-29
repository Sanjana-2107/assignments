using System;

namespace Q267398
{
    //  Create a class to store details of student like rollno, name, and course joined and fee paid so far.
    //  Assume courses are c# and ASP.NET with course fees being 2000 and 3000.
    //  Provide the constructor to take rollno,name,and course.
    //Provide the following methods:

    //1. Payment(amount)

    //2. Print()

    //3.DueAmount property

    //4. Total fee property
    class Program
    {
        static void Main(string[] args)
        {
            // Create John and Jane Student Detail Objects
            StudentDetails JohnStudentDetails = new StudentDetails(1001, "John", "c#");
            StudentDetails JaneStudentDetails = new StudentDetails(1002, "Jane", "ASP.NET");

            // Call Payment method
            JohnStudentDetails.Payment(200);
            JaneStudentDetails.Payment(100);

            // Print out student details
            JohnStudentDetails.Print();

            Console.WriteLine("\n");


            JaneStudentDetails.Print();
        }
    }

    /// <summary>
    /// Student Details Class
    /// Stores Student information
    /// </summary>
    class StudentDetails
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string CourseJoined { get; set; }
        public int FeePaidSoFar { get; set; }


        /// <summary>
        /// Property to determine amount due on class fee
        /// </summary>
        public int DueAmount
        {
            get
            {
                return TotalFee - FeePaidSoFar;
            }
        }

        /// <summary>
        /// Property to determine total fee based on enrolled course
        /// </summary>
        public int TotalFee
        {
            get
            {
                if (CourseJoined.ToLower() == "c#")
                    return 2000;
                else if (CourseJoined.ToLower() == "asp.net")
                    return 3000;
                return 0;
            }
        }

        public StudentDetails(int rollNo, string name, string courseJoined)
        {
            RollNo = rollNo;
            Name = name;
            CourseJoined = courseJoined;
        }

        /// <summary>
        /// Method for Student to pay fees
        /// </summary>
        /// <param name="amount"></param>
        public void Payment(int amount)
        {
            FeePaidSoFar += amount;
        }

        /// <summary>
        /// Outputs student details to console
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Course Joined: {CourseJoined}");
            Console.WriteLine($"Total Fee: {TotalFee}");
            Console.WriteLine($"Fee Paid So Far: {FeePaidSoFar}");
            Console.WriteLine($"Due Amount: {DueAmount}");
        }
    }
}