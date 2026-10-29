// Информация о студенте
string studentName = "Иса Заумаев";
string GroupName = "РУПО-265";

int age = 18;
int course = 2;

// Оценки студента
int score1 = 5;
int score2 = 3;
int score3 = 4;

const int ScoresCount = 3;

double averageScore = (double)(score1 + score2 + score3) / (ScoresCount);
// Выводим визитку студента
Console.WriteLine("===========================");
Console.WriteLine("    ВИЗИТКА СТУДЕНТА");
Console.WriteLine("===========================");


Console.WriteLine($"Студент {studentName}");
Console.WriteLine($"Возраст {age}");
Console.WriteLine($"Группа {GroupName}");
Console.WriteLine($"Курс {course}");

Console.WriteLine();
Console.WriteLine("-----Успеваемость-----");
Console.WriteLine($"Оценки {score1}, {score2}, {score3}");
Console.WriteLine($"Средний балл {averageScore:F2}");

bool isWorking = false;
string programmingGoal = "Изучаю язык С# и основы программирования";
Console.WriteLine();
Console.WriteLine($"Работает {isWorking}");
Console.WriteLine($"Цель обучения {programmingGoal}");