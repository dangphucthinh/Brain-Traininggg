using System.Diagnostics;

namespace ConsoleApp1
{
    public class GradingStudents
    {
        // Làm tròn điểm số học sinh.
        // Nếu điểm < 38 =>  fail
        // Nếu điểm làm tròn lên < 3 => làm tròn lên số gần nhất(Ví dụ: 73 => 75, 38 => 40)
        // Nếu điểm làm tròn >= 3 ==>  giữ nguyên( Ví dụ: 67 => 67, 82 => 82)
        public static List<int> GradingStudent(List<int> grades)
        {
            var surplus = 0;
            for(int i = 0;  i < grades.Count; i++)
            {
                if (grades[i] >= 38)
                {
                    surplus = grades[i] % 5;
                    if (surplus >= 3)
                    {
                        grades[i] = grades[i] + 5 - surplus;
                    }
                }
            }
            return grades;
        }
    }
}
