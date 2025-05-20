namespace Pair
{
    // Дан массив в котором 2n+1 чисел, 2n чисел из этого множества
    // имеют пару с друг другом и одно число не имеет пару (2 одинаковых числа являются парой)
    // Предложите алгоритм который найдёт это единственное число
    // без пары
    public class Pair
    {
        int[] Numbers;
        public Pair(int[] numbers)
        {
            if (numbers == null) throw new ArgumentNullException(nameof(numbers));
            if (numbers.Length % 2 != 1) throw new ArgumentNullException(nameof(numbers) + "Array should  be  массив в котором 2n+1 чисел ");

            Numbers = numbers;

        }
        /// <summary>
        /// Более умный поискпары
        /// </summary>
        /// <returns></returns>
        public int GetUnPairClever()
        {
            // haveNotPairs HashSet содержит все числа которые мы  подозреваем не имеют пары
            var haveNotPairs = new HashSet<int>(Numbers.Length);
            for (int i = 0; i < Numbers.Length; i++)
            {
                int number = Numbers[i];
                if (haveNotPairs.Contains(number))
                {
                    // Если число уже есть в HashSet, то оно имеет пару и мы его удаляем
                    haveNotPairs.Remove(number);

                }
                // Если числа нет  в списке на  подозреваемые что есть пара  мы его добавляем туда 
                else { haveNotPairs.Add(number); }

            }
            ///по условиям  в списке подозреваемых должно остаться одно число которое не имеет пары
            return haveNotPairs.First();
        }

        public int GetUnPairSimple()
        {

            var pairs = new Dictionary<int, int>();
            for (int i = 0; i < Numbers.Length; i++)
            {
                int number = Numbers[i];
                if (pairs.Keys.Contains(number))
                {
                    pairs[number]++;

                }
                else { pairs.Add(number, 1); }
            }
            return pairs.Where(p => p.Value == 1).First().Key;
        }

    }
}

