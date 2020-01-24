using System;

namespace MyConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////var helloWorld = "Hello World!";
            ////Console.Write(helloWorld);
            //var readLine1 = Console.ReadLine();
            //var readLine2 = Console.ReadLine();
            //var readLine3 = Console.ReadLine();

            //int firstNumber = int.Parse (readLine1);
            //int secondNumber = int.Parse (readLine2);
            //int thirdNumber = int.Parse (readLine3);

            //var sum = (firstNumber + secondNumber) * thirdNumber;
            //Console.Write(sum);
            //int divisible = int.Parse(Console.ReadLine());
            //int divisor = int.Parse(Console.ReadLine());
            //int quotient = (divisible / divisor);
            //bool divisibleMoreThanHundred = divisible > 100;
            //bool divisorMoreThanHundred = divisor < 1;
            //if (divisibleMoreThanHundred)
            //    Console.WriteLine("Вы делите слишком большое число");
            //if (divisorMoreThanHundred)
            //    Console.WriteLine("Вы делите на слишком большое число");
            //else Console.WriteLine("Результат деления = " + quotient);

            //int divisible = int.Parse(Console.ReadLine());
            //int divisor = int.Parse(Console.ReadLine());
            //if (divisor == 0)
            //{
            //    Console.WriteLine("На ноль делить нельзя!");
            //}
            //else
            //{
            //    double quotient = (divisible / divisor);
            //    Console.WriteLine("Ваш результат = " + quotient);
            //}

            //            var firstWord = "Пейте";
            //            var welcomePhrase = "Давайте вспомним популярную детскую песню: пишите по одному слову, а я буду Вам помогать. Я начну: " + firstWord + "... Что дальше? Подсказка: это слово-обращение";
            //            Console.WriteLine(welcomePhrase);
            //            var secondWord = Console.ReadLine();
            //            var children = "дети";
            //            var milk = "молоко";
            //            var health = "здоровы";
            //            var fifthWord = "будете";
            //            if (secondWord != "дети")
            //            {
            //                Console.WriteLine("А вот и не угадали, это маленькие люди. Как их назвать?");
            //                var newSecondWord = Console.ReadLine();
            //                if (newSecondWord != "дети")
            //                {
            //                    Console.WriteLine("Нет, мы ими были в детстве. Кто это?");
            //                }
            //                var lastSecondWord = Console.ReadLine();
            //                if (lastSecondWord != "дети")
            //                {
            //                    Console.WriteLine("Сдаётесь? Это же " + children + "! А что было дальше? Пишите слово!");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Правильно, это " + secondWord + " , идём дальше! Следующее слово?");
            //            }
            //            var thirdWord = Console.ReadLine();
            //            if (thirdWord != "молоко")
            //            {
            //                Console.WriteLine("Подумайте, какой первый напиток в нашей жизни?");
            //                var newThirdWord = Console.ReadLine();
            //                if (newThirdWord != "молоко")
            //                {
            //                    Console.WriteLine("Неправда! Это же " + milk + "! Получилось: " + firstWord + ", " + children + ", " + milk + ", " + fifthWord + " - что?");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Правильно, это " + newThirdWord + ", идём дальше! Начало песни: " + firstWord + ", " + children + ", " + milk + ", " + fifthWord + " - что дальше?");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Отлично!  Получилось " + firstWord + ", " + children + ", " + milk + ", " + fifthWord + " - что?");
            //            }
            //            var fourthWord = Console.ReadLine();
            //            if (fourthWord != "здоровы")
            //            {
            //                Console.WriteLine("Не угадали. Какими вы будете, если будете пить " + milk + "?");
            //                var newfourthWord = Console.ReadLine();
            //                if (newfourthWord == "здоровы"
            //                 || newfourthWord == "здоровыми"
            //                 || newfourthWord == "здоровым")
            //                {
            //                    Console.WriteLine("Ура, вы отгадали! Итак, наша песня: " + firstWord + ", " + children + ", " + milk + ", " + fifthWord + " " + health + ". Вы большой молодец! Может, вы ещё и 2*2 знаете?");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Подумайте.. Ладно, подскажу Вам: Вы будете " + health + "! Итак, наша песня: " + firstWord + ", " + children + ", " + milk + ", " + fifthWord + " " + health + ". Вы большой молодец! Может, вы ещё и 2*2 знаете?");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("В точку! Итак, наша песня: " + firstWord + ", " + children + ", " + milk + ", " + fifthWord + " " + health + ". Вы большой молодец! Может, вы ещё и 2*2 знаете?");
            //            }
            //            var number = (Console.ReadLine());
            //            if (number == "4")
            //            {
            //                Console.WriteLine("Да! А мы с вами отлично сработались и повеселились!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Да вы шутите? Зато мы отлично спели!");
            //            }
            //        }
            //    }
            //}

            var day = DayOfWeek.Monday;
            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Этот день - будний");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Этот день - будний");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Этот день - будний");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Этот день - будний");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Этот день - будний");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Этот день - выходной");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Этот день - выходной");
                    break;
            }
        }
    }
}