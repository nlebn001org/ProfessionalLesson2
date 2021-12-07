using System;
using System.Collections.Generic;

namespace ProfessionalLesson2Task3
{
    //    Задание 3
    //Несколькими способами создайте коллекцию, в которой можно хранить только целочисленные и
    //вещественные значения, по типу «счет предприятия – доступная сумма» соответственно.

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, uint> acc = new Dictionary<uint, uint>();          //account, amount
            acc.Add(1112223333, 500);

            List<(uint account, uint amount)> acc2 = new List<(uint account, uint amount)>();
            acc2.Add((1112223333, 500));
        }
    }
}
